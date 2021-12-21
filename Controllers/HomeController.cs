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

        public HomeController(ILogger<HomeController> logger, ImagesDbContext iContext, NoticeDbContext nContext)
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

            _iContext  = iContext;
            _nContext = nContext;
            _logger = logger;
        }

        public  async Task<IActionResult>  Index()
        {
            

           // string cookieidFromReq = Request.Cookies["curid"];
           // if(cookieidFromReq!=null){ 
                ViewData["curName"] =  Request.Cookies["curName"];
          //  }
            // HttpCookie userInfo = new HttpCookie("userInfo");
            // userInfo["UserName"] = "Annathurai";
            // userInfo["UserColor"] = "Black";
            // userInfo.Expires.Add(new TimeSpan(0, 1, 0));
            // Response.Cookies.Add(userInfo);
            // HttpContext.Session.SetInt32("curId",83);
            //HttpContext.Session.SetString("curName","Arman");

            // ViewData["curId"]=HttpContext.Session.GetInt32("curId");
            // ViewData["curName"]=HttpContext.Session.GetString("curName");
            // Console.WriteLine(HttpContext.Session.GetString("curName"));

            var image_ = await _iContext.__images.ToListAsync();
            
            

            List<ImageUp> imageList = new List<ImageUp>();

            foreach(ImageUp i in image_)
            {
                if(string.Compare(i.ImageName, "homeimage")==0)
                {
                    imageList.Add(i);
                }
            }
            var noticeList = await _nContext._notices.ToListAsync();

           CollectionDataModel model = new CollectionDataModel();
           model.Images = imageList;
           model.Notices = noticeList;


            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
