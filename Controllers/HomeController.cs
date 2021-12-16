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

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
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

        
            _logger = logger;
        }

        public IActionResult Index()
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
            return View();
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
