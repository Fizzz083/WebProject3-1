using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyWebApp.Models;
using Microsoft.AspNetCore.Http;
using System.Web;
using MyWebApp.Data;
using System.Net;
using Newtonsoft.Json;

using System.IO;
using X.PagedList;
using Microsoft.EntityFrameworkCore;


namespace MyWebApp.Controllers
{

    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ImagesDbContext _iContext;
        public NoticeDbContext _nContext;
        public UsersDbContext _uContext;

        public static DateTime UnixTimeStampToDateTime(int unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        List<publish_submission> func_for_user(string user_name)
        {
            List<publish_submission> a = new List<publish_submission>();

            var url = "https://codeforces.com/api/user.status?handle=" + user_name + "&from=1&count=5";


            try
            {

                var w = new WebClient();

                string json_data = w.DownloadString(url);

                if (json_data != null)
                {

                    for_submission con = JsonConvert.DeserializeObject<for_submission>(json_data);

                    //ViewBag.m = con.result[1].id - 19;




                    for (int i = 0; i < con.result.Count; i++)
                    {
                        publish_submission tmp = new publish_submission();

                        tmp.user_name = user_name;
                        tmp.problem_name = con.result[i].problem.name;
                        tmp.problem_id = con.result[i].problem.index;
                        tmp.contest_id = (con.result[i].contestId).ToString();
                        tmp.verdict = con.result[i].verdict;
                        DateTime dateTimeOffset = UnixTimeStampToDateTime(con.result[i].creationTimeSeconds);
                        // Console.WriteLine(dateTimeOffset);
                        tmp.time_ = dateTimeOffset.ToString();

                        Console.Write(tmp.problem_name);
                        Console.Write("  ");
                        Console.WriteLine(tmp.user_name);



                        a.Add(tmp);
                    }
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
        }

        public HomeController(ILogger<HomeController> logger, ImagesDbContext iContext, NoticeDbContext nContext, UsersDbContext uContext)
        {
            //    HttpContext.Session.SetString("curName", "Arman");
            //     var Reff = HttpContext.Session.GetString("curName") ;
            //     if(Reff!=null)
            //     {
            //         ViewData["curName"] = Reff;
            //     }
            //     else
            //     {

            //     }

            _iContext = iContext;
            _nContext = nContext;
            _logger = logger;
            _uContext = uContext;
        }

        long ConvertToTimestamp(DateTime value)
        {
            

            long epoch = (value.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
            return epoch;
        }

        public async Task<IActionResult> Index()
        {

            ViewData["curName"] = Request.Cookies["curName"];

            var image_ = await _iContext.__images.ToListAsync();



            List<ImageUp> imageList = new List<ImageUp>();

            foreach (ImageUp i in image_)
            {
                if (string.Compare(i.ImageName, "homeimage") == 0)
                {
                    imageList.Add(i);
                }
            }

            var all_user = await _uContext._users.ToListAsync();

            List<publish_submission> problems_running = new List<publish_submission>();

            if (all_user != null)
                foreach (Users u in all_user)
                {
                    if (u.CfId == null) continue;
                    List<publish_submission> u_problems_running = new List<publish_submission>();
                    u_problems_running = func_for_user(u.CfId);



                    foreach (publish_submission p in u_problems_running)
                    {

                        Console.Write(p.problem_name);
                        Console.Write("  ");
                        Console.WriteLine(p.user_name);


                        problems_running.Add(p);
                    }
                }


            Console.WriteLine(problems_running.Count);


            problems_running.Sort(
                delegate (publish_submission p1, publish_submission p2)
                {
                    if( Convert.ToDateTime(p1.time_)<Convert.ToDateTime(p2.time_))
                    {
                        return 1;
                    }
                    else return 0;
                }
            );

            problems_running = problems_running.GetRange(0,Math.Min(20,(int)problems_running.Count));

            
            var noticeList = await _nContext._notices.ToListAsync();

            CollectionDataModel model = new CollectionDataModel();
            model.Images = imageList;
            model.Notices = noticeList;
            model.Publish_submission = problems_running;


            return View(model);
        }

        public async Task<IActionResult> Notice()
        {

            ViewData["curName"] = Request.Cookies["curName"];  
            var noticeList = await _nContext._notices.ToListAsync();
            CollectionDataModel model = new CollectionDataModel();
            model.Notices = noticeList;

            return View(model);
        }

        

        
         public async Task<IActionResult> NoticeDetails(int? id)
        {
             ViewData["curName"] = Request.Cookies["curName"];

             var notice = await _nContext._notices.FindAsync(id);
            if (notice == null)
            {
                return NotFound();
            }
            return View(notice);

        }

        public IActionResult Privacy()
        {
             ViewData["curName"] = Request.Cookies["curName"];
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
             ViewData["curName"] = Request.Cookies["curName"];
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
