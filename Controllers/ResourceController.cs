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
    public class ResourceController : Controller
    {

        public UsersDbContext _context;
        public ImagesDbContext _iContext;
        public TeacherInfoDbContext _tContext;
        public AddProblemsDbContext _pContext;
        public NoticeDbContext _nContext;
        public TeamDbContext _teContext;
        public ArchiveDbContext _aContext;
        public ResourceDbContext _rContext;
        public ResourceController(UsersDbContext context, ImagesDbContext iContext, TeacherInfoDbContext tContext, AddProblemsDbContext pContext, NoticeDbContext nContext, TeamDbContext teContext, ArchiveDbContext aContext, ResourceDbContext rContext)
        {
            _context = context;
            _iContext = iContext;
            _tContext = tContext;
            _pContext = pContext;
            _nContext = nContext;
            _teContext = teContext;
            _aContext = aContext;
            _rContext = rContext;
        }

        public async Task<IActionResult> Index()
        {
            CollectionDataModel model = new CollectionDataModel();
            var resource_ = await _rContext._Resource.ToListAsync();
            model.Resources = resource_;
            return View(model);
        }

        public IActionResult AddResource()
        {
            string cookieValueFromReq = Request.Cookies["curName"];
            ViewData["curName"] = cookieValueFromReq;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> AddResource([Bind("RId,ShortDescription,Description,AddedBy,Topic,Datafiles")] Resource resource, IFormFile files)
        {
            if (ModelState.IsValid)
            {
                 string cookieValueFromReq = Request.Cookies["curName"];

                resource.AddedBy = cookieValueFromReq;

                if (files != null)
                {
                    Console.WriteLine("getting any files");
                    if (files.Length > 0)
                    {
                        var fileName = Path.GetFileName(files.FileName);
                        var filext = Path.GetExtension(fileName);
                        var newFileName = String.Concat(fileName, filext);
                        var objfiles = new Resource()
                        {
                            RId = resource.RId,
                            ShortDescription = resource.ShortDescription,
                            Description = resource.Description,
                            AddedBy = resource.AddedBy,
                            Topic = resource.Topic
                        };
                        using (var target = new MemoryStream())
                        {
                            files.CopyTo(target);
                            objfiles.Datafiles = target.ToArray();
                        }

                        
                            _rContext._Resource.Add(objfiles);
                            _rContext.SaveChanges();
                        


                        Console.WriteLine("file Uploaded..");
                    }
                }
                else
                {
                     _rContext._Resource.Add(resource);
                    _rContext.SaveChanges();
                    
                    Console.WriteLine("Not Found any files....");
                }



                return RedirectToAction(nameof(Index));
            }
            else
            {
                Console.WriteLine("error to add new resource");
                return View();
            }
        }



        public async Task<IActionResult> ResourceDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resource = await _rContext._Resource
                .FirstOrDefaultAsync(m => m.RId == id);
            if (resource == null)
            {
                return NotFound();
            }

            return View(resource);
        }

        // POST: Users/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> ResourceDelete(int id)
        {

            Console.WriteLine("deleting Resource...");
            var resource = await _rContext._Resource.FindAsync(id);

            if (resource != null)
            {
                Console.WriteLine("found resource for delete...");
                _rContext._Resource.Remove(resource);
                await _rContext.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
        
        public async Task<IActionResult> ResourceDetails(int? id)
        {
            var resource = await _rContext._Resource
                .FirstOrDefaultAsync(m => m.RId == id);
            if (resource == null)
            {
                Console.Write("Not Founded resource for showing the details..");
                return NotFound();
            }
            return View(resource);
        }


    }
}
