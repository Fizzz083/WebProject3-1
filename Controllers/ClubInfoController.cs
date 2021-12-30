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
    public class ClubInfoController : Controller
    {

        public UsersDbContext _context;
        public ImagesDbContext _iContext;
        public TeacherInfoDbContext _tContext;
        public AddProblemsDbContext _pContext;
        public NoticeDbContext _nContext;
        public TeamDbContext _teContext;
        public ArchiveDbContext _aContext;
        public ClubInfoController(UsersDbContext context, ImagesDbContext iContext, TeacherInfoDbContext tContext, AddProblemsDbContext pContext, NoticeDbContext nContext, TeamDbContext teContext, ArchiveDbContext aContext)
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

        int getRating(string cfid)
        {
            int ret = 0;

            /*
            var url = "https://codeforces.com/api/user.status?handle=" + user_name + "&from=1&count=5";


            try
            {

                var w = new WebClient();

                string json_data = w.DownloadString(url);

                if (json_data != null)
                {

                    for_submission con = JsonConvert.DeserializeObject<for_submission>(json_data);

                    //ViewBag.m = con.result[1].id - 
                    Console.WriteLine(a.Count);
                    return a;

                }
                else
                {
                    return a;

                }
            }
            catch (Exception)
            {
                return a;
            }
            */

            return ret;
        }


        public async Task<IActionResult> Index()
        {
            CollectionDataModel model = new CollectionDataModel();

            var teachers_ = await _tContext._teachers.ToListAsync();
            var teams_ = await _teContext._teams.ToListAsync();
            var archive__ = await _aContext._archives.ToListAsync();
            var users_ = await _context._users.ToListAsync();

            model.Teachers = teachers_;
            model.Teams = teams_;
            model.Archives = archive__;

            List<UserWithRating> UWR = new List<UserWithRating>();
            
            foreach( Users u in users_)
            {
                UserWithRating uw = new UserWithRating();

                uw.users = u;

                uw.rating = getRating(u.CfId);

                UWR.Add(uw);
            }

            model.usersWithRating = UWR;



            return View(model);
        }

    }
}