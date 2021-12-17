using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyWebApp.Data;
using MyWebApp.Models;
using Microsoft.AspNetCore.Http;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using X.PagedList;
using X.PagedList.Mvc;

namespace MyWebApp.Controllers
{
    public class AdminController : Controller
    {
        
        public UsersDbContext _context;
        public ImagesDbContext _iContext;
        public TeacherInfoDbContext _tContext;

        public AddProblemsDbContext _pContext;

        public AdminController(UsersDbContext context, ImagesDbContext iContext, TeacherInfoDbContext tContext, AddProblemsDbContext pContext)
        {
            // ViewData["curName"] = HttpContext.Session.GetString("curName");
            _context = context;
            _iContext = iContext;
            _tContext = tContext;
            _pContext = pContext;
        }

        

        public async Task<IActionResult> Index()
        {
            string cookieValueFromReq = Request.Cookies["curName"];  
            ViewData["curName"] = cookieValueFromReq;

            Console.Write("admin user: ");
            Console.WriteLine(ViewData["curName"]);

            string un = "FatPanda";
            string curname = cookieValueFromReq;


            if(String.Compare(curname, un)!=0)
            {
                return RedirectToAction("Index", "Home");
            }

            var teachers_ = await _tContext._teachers.ToListAsync();

           CollectionDataModel model = new CollectionDataModel();
           model.Teachers = teachers_;


            return View(model);
        }

        public IActionResult AddTeacher()
        {

            string cookieValueFromReq = Request.Cookies["curName"];
            ViewData["curName"] = cookieValueFromReq;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> AddTeacher([Bind("Id,Name,FullName,Email,PhoneNumber")] Teacher teacher)
        {
            if (ModelState.IsValid)
            {

                var users_ = await _context._users
                .FirstOrDefaultAsync(m => m.Name == teacher.Name);

                var teachercheck  = await _tContext._teachers
                .FirstOrDefaultAsync(m => m.Name == teacher.Name);
                if (users_ != null || teachercheck != null)
                {

                    ViewBag.Found = "found";

                    Console.WriteLine("FOUND");
                    return View();
                }

                 _tContext.Add(teacher);
                await _tContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        public async Task<IActionResult> TeacherDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacher = await _tContext._teachers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teacher == null)
            {
                return NotFound();
            }

            return View(teacher);
        }

        // POST: Users/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> TeacherDelete(int id)
        {

            Console.WriteLine("deleting teacher...");
            var users = await _tContext._teachers.FindAsync(id);

            if (users != null)
            {
                Console.WriteLine("found teacher for delete...");
                _tContext._teachers.Remove(users);
                await _tContext.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
        
        public async Task<IActionResult> TeacherDetails(int? id)
        {
            var teacher = await _tContext._teachers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teacher == null)
            {
                Console.Write("Not Founded Teacher for showing the details..");
                return NotFound();
            }

            var img = await _iContext.__images.FirstOrDefaultAsync(m => m.ImageName == teacher.Name);

            if (img != null)
            {
                string imageBase64Data = Convert.ToBase64String(img.Datafiles);
                string imageDataURL = string.Format("data:image/png;base64,{0}", imageBase64Data);
                ViewBag.ImageData = imageDataURL;
            }
            Console.Write("Founded Teacher for showing the details..");
            return View(teacher);
        }

        public async Task<IActionResult> TeacherEdit(int? id)
        {
            //ViewData["curName"] = HttpContext.Session.GetString("curName");
            if (id == null)
            {
                return NotFound();
            }

            var teacher = await _tContext._teachers.FindAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }
            return View(teacher);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TeacherEdit(int id, [Bind("Id,Name,FullName,Email,PhoneNUmber")] Teacher users, IFormFile files)
        {
            Console.WriteLine("teacher edit..");
            if (id != users.Id)
            {
                return NotFound();
            }

            var teacher = await _tContext._teachers.FindAsync(id);
            
            teacher.Email = users.Email;
            teacher.PhoneNUmber = users.PhoneNUmber;
            teacher.FullName = users.FullName;

            if (files != null)
            {
                Console.WriteLine("getting Image");
                if (files.Length > 0)
                {
                    var fileName = Path.GetFileName(files.FileName);
                    var filext = Path.GetExtension(fileName);
                    var newFileName = String.Concat(teacher.Name, filext);
                    var objfiles = new ImageUp()
                    {
                        ImageId = 0,
                        ImageName = teacher.Name
                    };
                    using (var target = new MemoryStream())
                    {
                        files.CopyTo(target);
                        objfiles.Datafiles = target.ToArray();
                    }

                    var img = await _iContext.__images.FirstOrDefaultAsync(m => m.ImageName == teacher.Name);

                    if (img != null)
                    {
                        //Console.WriteLine("ager image ase");
                        try
                        {
                            img.Datafiles = objfiles.Datafiles;

                            _iContext.Update(img);
                            await _iContext.SaveChangesAsync();
                            //Console.WriteLine("Update images");
                        }
                        catch (DbUpdateConcurrencyException)
                        {
                           // Console.WriteLine("Update images failes");
                            throw;
                        }
                    }
                    else
                    {

                        _iContext.__images.Add(objfiles);
                        _iContext.SaveChanges();
                    }
                    Console.WriteLine("Image Uploaded..");
                }
            }
            else
            {
                Console.WriteLine("Not Found Images....");
            }


            if (ModelState.IsValid)
            {
                try
                {
                    //    users.Password = Hashing.ToSha256(users.Password);
                    _tContext.Update(teacher);
                    await _tContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (teacher==null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            return View(users);
        }




    }
}