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
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using ClosedXML;

namespace MyWebApp.Controllers
{
    public class AdminController : Controller
    {

        public UsersDbContext _context;
        public ImagesDbContext _iContext;
        public TeacherInfoDbContext _tContext;
        public AddProblemsDbContext _pContext;
        public NoticeDbContext _nContext;
        public TeamDbContext _teContext;
        public ArchiveDbContext _aContext;
        public AdminController(UsersDbContext context, ImagesDbContext iContext, TeacherInfoDbContext tContext, AddProblemsDbContext pContext, NoticeDbContext nContext, TeamDbContext teContext, ArchiveDbContext aContext)
        {
            // ViewData["curName"] = HttpContext.Session.GetString("curName");
            _context = context;
            _iContext = iContext;
            _tContext = tContext;
            _pContext = pContext;
            _nContext = nContext;
            _teContext = teContext;
            _aContext = aContext;
        }




        public async Task<IActionResult> Index()
        {
            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }

            Console.Write("admin user: ");
            Console.WriteLine(ViewData["curName"]);

            string un = "FatPanda";
            string curname = cookieValueFromReq;


            if (String.Compare(curname, un) != 0)
            {
                return RedirectToAction("Index", "Home");
            }

            var teachers_ = await _tContext._teachers.ToListAsync();
            var notices_ = await _nContext._notices.ToListAsync();
            var teams_ = await _teContext._teams.ToListAsync();
            var archive__ = await _aContext._archives.ToListAsync();

            //  var homeimage = "homeImage";

            //var images_ =  _iContext.__images.Where(y => y.ImageName.Contains(homeimage)).ToList();



            var images_ = await _iContext.__images.ToListAsync();

            CollectionDataModel model = new CollectionDataModel();
            model.Teachers = teachers_;
            model.Notices = notices_;
            model.Teams = teams_;
            model.Archives = archive__;
            model.Images = images_;
            return View(model);
        }








        /* Teacher */
        public IActionResult AddTeacher()
        {
            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> AddTeacher([Bind("Id,Name,FullName,Email,PhoneNumber")] Teacher teacher)
        {
            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
            if (ModelState.IsValid)
            {

                var users_ = await _context._users
                .FirstOrDefaultAsync(m => m.Name == teacher.Name);

                var teachercheck = await _tContext._teachers
                .FirstOrDefaultAsync(m => m.Name == teacher.Name);
                if (users_ != null || teachercheck != null)
                {

                    ViewBag.Found = "found";

                    Console.WriteLine("FOUND");
                    return View();
                }

                Console.WriteLine(teacher.PhoneNUmber);

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
            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
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
            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }

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
            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
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
            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
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
            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
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
                    if (teacher == null)
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
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }



            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> AddNotice([Bind("NId,,ShortDescription,Description,Time")] Notice notice)
        {
            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
            if (ModelState.IsValid)
            {

                DateTime now = DateTime.Now;

                notice.Time = now.ToString();

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
            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
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
            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }

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
            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
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
            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
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
            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
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
                    if (notice_ == null)
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

        /* Notice - End */


















        /* .... Team ... */

        public IActionResult AddTeam()
        {
            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }


            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> AddTeam([Bind("TId,TeamName,Member1,Member2,Member3,Email,Phonenumber")] Team team)
        {
            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
            if (ModelState.IsValid)
            {


                _teContext.Add(team);
                await _teContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        public async Task<IActionResult> TeamDelete(int? id)
        {
            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
            if (id == null)
            {
                return NotFound();
            }

            var team_ = await _teContext._teams
                .FirstOrDefaultAsync(m => m.TId == id);
            if (team_ == null)
            {
                return NotFound();
            }

            return View(team_);
        }

        // POST: Users/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> TeamDelete(int id)
        {
            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }

            Console.WriteLine("deleting Team...");
            var team_ = await _teContext._teams
                .FirstOrDefaultAsync(m => m.TId == id);

            if (team_ != null)
            {
                Console.WriteLine("found teacher for delete...");
                _teContext._teams.Remove(team_);
                await _teContext.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> TeamDetails(int? id)
        {
            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
            var team_ = await _teContext._teams
                .FirstOrDefaultAsync(m => m.TId == id);
            if (team_ == null)
            {
                // Console.Write("Not Founded Notice for showing the details..");
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
            return View(team_);
        }

        public async Task<IActionResult> TeamEdit(int? id)
        {
            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
            //ViewData["curName"] = HttpContext.Session.GetString("curName");
            if (id == null)
            {
                return NotFound();
            }

            var team_ = await _teContext._teams
                .FirstOrDefaultAsync(m => m.TId == id);
            if (team_ == null)
            {
                return NotFound();
            }
            return View(team_);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TeamEdit(int id, [Bind("TId,TeamName,Member1,Member2,Member3,Email,Phonenumber")] Team team)
        {
            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
            Console.WriteLine("teacher edit..");
            if (id != team.TId)
            {
                return NotFound();
            }

            var team_ = await _teContext._teams
               .FirstOrDefaultAsync(m => m.TId == id);

            team_.TeamName = team.TeamName;
            team_.Member1 = team.Member1;
            team_.Member2 = team.Member2;
            team_.Member3 = team.Member3;
            team_.Email = team.Email;
            team_.Phonenumber = team.Phonenumber;




            // notice_.ShortDescription = notice.ShortDescription;
            // notice_.Description = notice.Description;



            if (ModelState.IsValid)
            {
                try
                {
                    //    users.Password = Hashing.ToSha256(users.Password);
                    _teContext.Update(team_);
                    await _teContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (team_ == null)
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
            return View(team_);
        }


        /* .... end - Team .... */

















        /* Archive */
        public IActionResult AddArchive()
        {
            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> AddArchive([Bind("AId,TeamName,Member1,Member2,Member3,ContestName,Year,Position")] Archive archive)
        {
            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
            if (ModelState.IsValid)
            {

                // var archive_ = await _aContext._archives
                // .FirstOrDefaultAsync(m => m.TeamName == archive.TeamName);



                _aContext.Add(archive);
                await _aContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        public async Task<IActionResult> ArchiveDelete(int? id)
        {
            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
            if (id == null)
            {
                return NotFound();
            }

            var archive_ = await _aContext._archives
                 .FirstOrDefaultAsync(m => m.AId == id);
            if (archive_ == null)
            {
                return NotFound();
            }

            return View(archive_);
        }

        // POST: Users/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> ArchiveDelete(int id)
        {

            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
            var archive_ = await _aContext._archives
                 .FirstOrDefaultAsync(m => m.AId == id);

            if (archive_ != null)
            {
                Console.WriteLine("found teacher for delete...");
                _aContext._archives.Remove(archive_);
                await _aContext.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ArchiveDetails(int? id)
        {
            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
            var archive_ = await _aContext._archives
                 .FirstOrDefaultAsync(m => m.AId == id);
            if (archive_ == null)
            {
                Console.Write("Not Founded Teacher for showing the details..");
                return NotFound();
            }


            Console.Write("Founded Teacher for showing the details..");
            return View(archive_);
        }

        public async Task<IActionResult> ArchiveEdit(int? id)
        {
            ViewData["curName"] = Request.Cookies["curName"];
            //ViewData["curName"] = HttpContext.Session.GetString("curName");
            if (id == null)
            {
                return NotFound();
            }

            var archive_ = await _aContext._archives
                  .FirstOrDefaultAsync(m => m.AId == id);
            if (archive_ == null)
            {
                return NotFound();
            }
            return View(archive_);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ArchiveEdit(int id, [Bind("AId,TeamName,Member1,Member2,Member3,ContestName,Year,Position")] Archive archive)
        {
            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
            if (id != archive.AId)
            {
                return NotFound();
            }

            var archive_ = await _aContext._archives.FindAsync(id);


            archive_.ContestName = archive.ContestName;
            archive_.TeamName = archive.TeamName;
            archive_.Member1 = archive.Member1;
            archive_.Member2 = archive.Member2;
            archive_.Member3 = archive.Member3;
            archive_.Year = archive.Year;
            archive_.Position = archive.Position;



            if (ModelState.IsValid)
            {
                try
                {
                    //    users.Password = Hashing.ToSha256(users.Password);
                    _aContext.Update(archive_);
                    await _tContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (archive_ == null)
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
            return View(archive_);
        }

        /* Archive - End */












        /* home image */

        public IActionResult AddHomeImage()
        {
            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> AddHomeImage(IFormFile files)
        {
            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
            if (ModelState.IsValid)
            {

                // var archive_ = await _aContext._archives
                // .FirstOrDefaultAsync(m => m.TeamName == archive.TeamName);

                if (files != null)
                {
                    Console.WriteLine("getting Image");
                    if (files.Length > 0)
                    {
                        var str = "homeimage";
                        var fileName = Path.GetFileName(files.FileName);
                        var filext = Path.GetExtension(fileName);
                        var newFileName = String.Concat(str, filext);
                        var objfiles = new ImageUp()
                        {
                            ImageId = 0,
                            ImageName = str
                        };
                        using (var target = new MemoryStream())
                        {
                            files.CopyTo(target);
                            objfiles.Datafiles = target.ToArray();
                        }



                        _iContext.__images.Add(objfiles);
                        _iContext.SaveChanges();

                        Console.WriteLine("Image Uploaded..");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found Images....");
                }



                //  _aContext.Add(archive);
                // await _aContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        public async Task<IActionResult> HomeImageDelete(int? id)
        {
            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
            if (id == null)
            {
                return NotFound();
            }

            var image_ = await _iContext.__images
                 .FirstOrDefaultAsync(m => m.ImageId == id);
            if (image_ == null)
            {
                return NotFound();
            }

            return View(image_);
        }

        // POST: Users/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> HomeImageDelete(int id)
        {
            string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else
            {

                ViewData["curName"] = HttpContext.Session.GetString("curName");
            }

            Console.WriteLine("deleting image...");
            var image_ = await _iContext.__images
                 .FirstOrDefaultAsync(m => m.ImageId == id);

            if (image_ != null)
            {
                Console.WriteLine("found image for delete...");
                _iContext.__images.Remove(image_);
                await _iContext.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }



        /* home image  end*/
    }
}