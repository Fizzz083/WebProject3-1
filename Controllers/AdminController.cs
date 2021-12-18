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

        public NoticeDbContext _nContext;
        public AdminController(UsersDbContext context, ImagesDbContext iContext, TeacherInfoDbContext tContext, AddProblemsDbContext pContext, NoticeDbContext nContext)
        {
            // ViewData["curName"] = HttpContext.Session.GetString("curName");
            _context = context;
            _iContext = iContext;
            _tContext = tContext;
            _pContext = pContext;
            _nContext = nContext;
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
            var notices_ = await _nContext._notices.ToListAsync();

           CollectionDataModel model = new CollectionDataModel();
           model.Teachers = teachers_;
           model.Notices = notices_;
            return View(model);
        }








        /* Teacher */
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

         /* Teacher - End */













         


         /* Notice */
        public IActionResult AddNotice()
        {
            string cookieValueFromReq = Request.Cookies["curName"];
            ViewData["curName"] = cookieValueFromReq;


            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> AddNotice([Bind("NId,,ShortDescription,Description,Time")] Notice notice)
        {
            if (ModelState.IsValid)
            {

                DateTime now = DateTime.Now; 

                notice.Time  = now.ToString();

                 _nContext.Add(notice);
                await _nContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        public async Task<IActionResult> NoticeDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notice = await _nContext._notices
                .FirstOrDefaultAsync(m => m.NId == id);
            if (notice == null)
            {
                return NotFound();
            }

            return View(notice);
        }

        // POST: Users/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> NoticeDelete(int id)
        {

            Console.WriteLine("deleting teacher...");
            var notice = await _nContext._notices
                .FirstOrDefaultAsync(m => m.NId == id);

            if (notice != null)
            {
                Console.WriteLine("found teacher for delete...");
                _nContext._notices.Remove(notice);
                await _nContext.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
        
        public async Task<IActionResult> NoticeDetails(int? id)
        {
            var notice = await _nContext._notices
                .FirstOrDefaultAsync(m => m.NId == id);
            if (notice == null)
            {
                Console.Write("Not Founded Notice for showing the details..");
                return NotFound();
            }

            //var img = await _iContext.__images.FirstOrDefaultAsync(m => m.ImageName == teacher.Name);

            // if (img != null)
            // {
            //     string imageBase64Data = Convert.ToBase64String(img.Datafiles);
            //     string imageDataURL = string.Format("data:image/png;base64,{0}", imageBase64Data);
            //     ViewBag.ImageData = imageDataURL;
            // }
            // Console.Write("Founded Teacher for showing the details..");
            return View(notice);
        }

        public async Task<IActionResult> NoticeEdit(int? id)
        {
            //ViewData["curName"] = HttpContext.Session.GetString("curName");
            if (id == null)
            {
                return NotFound();
            }

           var notice = await _nContext._notices
                .FirstOrDefaultAsync(m => m.NId == id);
            if (notice == null)
            {
                return NotFound();
            }
            return View(notice);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NoticeEdit(int id, [Bind("NId,ShortDescription,Description,Time")] Notice notice)
        {
            Console.WriteLine("teacher edit..");
            if (id != notice.NId)
            {
                return NotFound();
            }

            var notice_ = await _nContext._notices.FindAsync(id);
           

            notice_.ShortDescription = notice.ShortDescription;
            notice_.Description = notice.Description;

            

            if (ModelState.IsValid)
            {
                try
                {
                    //    users.Password = Hashing.ToSha256(users.Password);
                    _nContext.Update(notice_);
                    await _nContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (notice_==null)
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
            return View(notice_);
        }

         /* Teacher - End */



    }
}