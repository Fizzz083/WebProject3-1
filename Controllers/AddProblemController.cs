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
    public class AddProblemController : Controller
    {
        public UsersDbContext _context;
        public AddProblemsDbContext _pContext;


        public AddProblemController(UsersDbContext context, AddProblemsDbContext pContext)
        {
            _context = context;
            _pContext = pContext;
        }

        public async Task<IActionResult> Index(int? i)
        {
            string cookieValueFromReq = Request.Cookies["curName"];
            ViewData["curName"] = cookieValueFromReq;

            var problems = await _pContext._addProblems.ToListAsync();

            //IPagedList<AddProblem> pagedList = problems.ToPagedList(i ?? 1, 3);

            var models = problems.ToPagedList(i ?? 1,3);

            Console.WriteLine(i);
   

            // IPagedList<AddProblem> models = new IPagedList<AddProblem>(problems, i ?? 1, 2);

            return View(models);
        }

        public String uname;
        public IActionResult Create()
        {

            string cookieValueFromReq = Request.Cookies["curName"];
            ViewData["curName"] = cookieValueFromReq;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create([Bind("Pid,PName,PLink,PTag,PIdea, PAddedBy")] AddProblem problem)
        {
            if (ModelState.IsValid)
            {
                string cookieValueFromReq = Request.Cookies["curName"];
                ViewData["curName"] = cookieValueFromReq;
                problem.PAddedBy = cookieValueFromReq;

                if (problem.PAddedBy == null)
                {
                    return RedirectToAction("Error");
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
            return View();
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var problem = await _pContext._addProblems
                .FirstOrDefaultAsync(m => m.Pid == id);
            if (problem == null)
            {
                return NotFound();
            }

            return View(problem);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var problem = await _pContext._addProblems.FindAsync(id);
            _pContext._addProblems.Remove(problem);
            await _pContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}