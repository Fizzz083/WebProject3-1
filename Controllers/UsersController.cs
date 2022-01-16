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

namespace MyWebApp.Controllers
{
    public static class Hashing
    {
        public static string ToSha256(string s)
        {
            using var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(s));

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }

    }

    public class UsersController : Controller
    {
        HelperClass helperClass = new HelperClass();
        //  public baseuser baseuser_;
        public UsersDbContext _context;
        public ImagesDbContext _iContext;
        public AddProblemsDbContext _pContext;
        public ResourceDbContext _rContext;

        public UsersController(AddProblemsDbContext pContext,ResourceDbContext rContext, UsersDbContext context, ImagesDbContext iContext)
        {
            // ViewData["curName"] = HttpContext.Session.GetString("curName");
            _context = context;
            _iContext = iContext;
            _rContext = rContext;
            _pContext = pContext;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            string cookieValueFromReq = Request.Cookies["curName"];  
            ViewData["curName"] = cookieValueFromReq;
            if (ViewData["curName"] == null)
            {
                //Console.WriteLine("Calling the details");
                return RedirectToAction("Index", "Home");
            }
           // ViewData["curId"] = HttpContext.Session.GetInt32("curId");
            //ViewData["curId"]= helperClass.getUniqueId();
            return View(await _context._users.ToListAsync());
        }

        public async Task<IActionResult> Logout()
        {
            Response.Cookies.Delete("curName");  
           // HttpContext.Session.SetString("curName", "Arman");
            //   return 
            return RedirectToAction("Index", "Home");

        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details()
        {
           
            string cookieValueFromReq = Request.Cookies["curName"];  
            ViewData["curName"] = cookieValueFromReq;
             Console.WriteLine(ViewData["curName"]);
            //ViewData["curName"] = HttpContext.Session.GetString("curName");
            if (ViewData["curName"] == null)
            {
                Console.WriteLine("Calling the details");
                return NotFound();
            }

            string user = ViewData["curName"].ToString();

            if(user==null)
            {
                return RedirectToAction("Index", "Home");
            }

            var users = await _context._users
                .FirstOrDefaultAsync(m => m.Name == user);
            if (users == null)
            {
                Console.Write("Not Founded user for showing the details..");
                return NotFound();
            }

            var img = await _iContext.__images.FirstOrDefaultAsync(m => m.ImageName == user);

            if (img != null)
            {
                string imageBase64Data = Convert.ToBase64String(img.Datafiles);
                string imageDataURL = string.Format("data:image/png;base64,{0}", imageBase64Data);
                ViewBag.ImageData = imageDataURL;
            }

             CollectionDataModel model = new CollectionDataModel();
            var resource_ = await _rContext._Resource.Where(m=> m.AddedBy==user).ToListAsync();

            model.Resources = resource_;
            var problem_ = await _pContext._addProblems.Where(m=> m.PAddedBy==user).ToListAsync();
            model.AddProblems = problem_;
            model.users = users;


            Console.Write("Founded user for showing the details..");
            return View(model);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.



        [HttpPost]
        [ValidateAntiForgeryToken]


        public async Task<IActionResult> Create([Bind("UserId,Name,FullName,Email,PhoneNUmber,Password,CfId,LightOjId,CodechefId")] Users users)
        {
            if (ModelState.IsValid)
            {
                // HelperClass a = new HelperClass();

                var users_ = await _context._users
                .FirstOrDefaultAsync(m => m.Name == users.Name);
                if (users_ != null)
                {

                    ViewBag.Found = "found";

                    Console.WriteLine("FOUND");
                    return View();
                }


                //int b  = a.getUniqueId();   

                helperClass.setUniqueId(users.UserId);
                users.Password = Hashing.ToSha256(users.Password);

                // users.UserId = b;
                _context.Add(users);
                // _context.Add(userlog);
                await _context.SaveChangesAsync();

                CookieOptions option = new CookieOptions();
                option.Expires = DateTime.Now.AddSeconds(7200);
                Response.Cookies.Append("curName", users.Name, option);

                string cookieValueFromReq = Request.Cookies["curName"];  
                 ViewData["curName"] = cookieValueFromReq;

                // HttpContext.Session.SetInt32("curId", users.UserId);
                // HttpContext.Session.SetString("curName", users.Name);
                // ViewData["curId"] = HttpContext.Session.GetInt32("curId");
                // ViewData["curName"] = HttpContext.Session.GetString
                // ("curName");

                return RedirectToAction("Index", "Home");
            }
            return View(users);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]


        public async Task<IActionResult> Login([Bind("UserId,Name,Password")] Userlogin userlogin)
        {
            if (ModelState.IsValid)
            {

                String checkPassword = Hashing.ToSha256(userlogin.Password);

                var users = await _context._users
                .FirstOrDefaultAsync(m => m.Name == userlogin.Name && m.Password == checkPassword);
                if (users == null)
                {
                    Console.WriteLine("NOTFOUND fro logging...");
                    return View();
                }
                Console.WriteLine("FOund");
              
                CookieOptions option = new CookieOptions();
                option.Expires = DateTime.Now.AddSeconds(3600);
                Response.Cookies.Append("curName", users.Name, option);

                 CookieOptions option2 = new CookieOptions();
                option2.Expires = DateTime.Now.AddSeconds(3600);
                Response.Cookies.Append("curid", "1", option2);

                string cookieValueFromReq = Request.Cookies["curName"];  
                ViewData["curName"] = cookieValueFromReq;

                return RedirectToAction("Index", "Home");

                //userloginController userloginController = new userloginController(_context);
                //userloginController.Create(userlog);

                // return RedirectToAction(nameof(Index));
            }
            else
            {
                Console.WriteLine("Hello there..");
                return RedirectToAction("Index", "Home");
            }
            //Console.WriteLine("Hello there..");
            //return RedirectToAction("Index", "Home");
            // return RedirectToAction("./Views/Home/Index.cshtml");
            //return View();
        }




        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
             ViewData["curName"] = Request.Cookies["curName"];
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context._users.FindAsync(id);
            if (users == null)
            {
                return NotFound();
            }
            return View(users);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId, FullName,Email,PhoneNUmber,CfId,LightOjId,CodechefId")] UserEdit users, IFormFile files)
        {
             ViewData["curName"] = Request.Cookies["curName"];
            if (id != users.UserId)
            {
                return NotFound();
            }

            var usersup = await _context._users.FindAsync(id);
            usersup.CfId = users.CfId;
            usersup.LightOjId = users.LightOjId;
            usersup.CodechefId = users.CodechefId;
            usersup.Email = users.Email;
            usersup.PhoneNUmber = users.PhoneNUmber;
            usersup.FullName = users.FullName;

            if (files != null)
            {
                Console.WriteLine("getting Image");
                if (files.Length > 0)
                {
                    var fileName = Path.GetFileName(files.FileName);
                    var filext = Path.GetExtension(fileName);
                    var newFileName = String.Concat(usersup.Name, filext);
                    var objfiles = new ImageUp()
                    {
                        ImageId = 0,
                        ImageName = usersup.Name
                    };
                    using (var target = new MemoryStream())
                    {
                        files.CopyTo(target);
                        objfiles.Datafiles = target.ToArray();
                    }

                    var img = await _iContext.__images.FirstOrDefaultAsync(m => m.ImageName == usersup.Name);

                    if (img != null)
                    {
                        Console.WriteLine("ager image ase");
                        try
                        {
                            img.Datafiles = objfiles.Datafiles;

                            _iContext.Update(img);
                            await _iContext.SaveChangesAsync();

                            Console.WriteLine("Update images");
                        }
                        catch (DbUpdateConcurrencyException)
                        {
                            Console.WriteLine("Update images failes");

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

                    _context.Update(usersup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsersExists(users.UserId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Details));
            }
            // return RedirectToAction("./Views/Home/Index.cshtml");
            //Console.WriteLine("Hello ");
            return View(users);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
             ViewData["curName"] = Request.Cookies["curName"];
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context._users
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (users == null)
            {
                return NotFound();
            }

            return View(users);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var users = await _context._users.FindAsync(id);
            _context._users.Remove(users);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsersExists(int id)
        {
            return _context._users.Any(e => e.UserId == id);
        }
    }
}
