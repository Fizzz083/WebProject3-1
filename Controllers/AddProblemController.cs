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
using X.PagedList.Mvc.Core;
using X.PagedList.Mvc.Common;
using System.Web;
// using PagedList.Mvc;
// using PagedList;
// using PagedList.Core.Mvc;

namespace MyWebApp.Controllers
{
    public class AddProblemController : Controller
    {
        public UsersDbContext _context;
        public AddProblemsDbContext _pContext;


        public AddProblemController(UsersDbContext context, AddProblemsDbContext pContext)
        {
            _context = context;
            _pContext = pContext;
        }


        public async Task<IActionResult> Index(int? i, int? size)
        {
            //var size_ = (string)size;
            int sizee = 0;
                if(size!=null)
                sizee = (int)size;
             string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else{
                
                 ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
            ViewData["size"] = 0;
            ViewData["done"] = 0;
            ViewData["extra"] = 0;

            Console.WriteLine(size);
            Console.WriteLine(sizee);
             


            var problems = await _pContext._addProblems.ToListAsync();
            var confirm_list = new List<AddProblem>() ;


            if(i==1)
            {
                 var s = sizee;
                confirm_list = problems.GetRange(s, 5);
                sizee = s+5;

            }
            else if(i==2)
            {
                var s = Math.Min(sizee+5,problems.Count);
                var rase = Math.Min(5,problems.Count-sizee );
                
                
                confirm_list = problems.GetRange(sizee, rase);
                Console.WriteLine("size: "+s);
                sizee = s;
                if(s==problems.Count)
                {
                     ViewData["done"] = 1;
                     ViewData["extra"] = rase;
                   //  sizee=0;
                }
            }
            else{

                //var s = Math.Min(sizee+5,problems.Count);
                var rase = Math.Min(5,problems.Count );
                Console.WriteLine("size: "+rase);
                confirm_list = problems.GetRange(0, rase);
                sizee = rase;
               
            }
             ViewData["size"] = sizee;
              Console.WriteLine(sizee);

            //IPagedList<AddProblem> pagedList = problems.ToPagedList(i ?? 1, 3);
   

            return View(confirm_list);
        }

        public String uname;
        public IActionResult Create()
        {
 string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else{
                
                 ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
            if(cookieValueFromReq==null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create([Bind("Pid,PName,PLink,PTag,PIdea, PAddedBy")] AddProblem problem)
        {
            if (ModelState.IsValid)
            {
                string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else{
                
                 ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
                problem.PAddedBy = (string)ViewData["curName"] ;

                if (problem.PAddedBy == null)
                {
                    return RedirectToAction("Error","Users");
                }
                _pContext.Add(problem);
                await _pContext.SaveChangesAsync();

                ViewBag.SuccesAdd = "1";

                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        public IActionResult Error()
        {
             string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else{
                
                 ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
            return View();
        }

        public async Task<IActionResult> Delete(int? id)
        {
             string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else{
                
                 ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
            if (id == null)
            {
                return RedirectToAction("Error","Users");
            }

            var problem = await _pContext._addProblems
                .FirstOrDefaultAsync(m => m.Pid == id);
            if (problem == null)
            {
               return RedirectToAction("Error","Users");
            }

            return View(problem);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
             string cookieValueFromReq = Request.Cookies["curName"];
            //ViewData["curName"] = cookieValueFromReq;

            if (cookieValueFromReq != null)
            {

                ViewData["curName"] = cookieValueFromReq;
            }
            else{
                
                 ViewData["curName"] = HttpContext.Session.GetString("curName");
            }
            var problem = await _pContext._addProblems.FindAsync(id);
            _pContext._addProblems.Remove(problem);
            await _pContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}