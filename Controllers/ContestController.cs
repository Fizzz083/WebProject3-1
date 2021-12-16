using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyWebApp.Models;
using Newtonsoft.Json;

using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyWebApp.Data;
using Microsoft.AspNetCore.Http;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace MyWebApp.Controllers
{
    public class contestController : Controller
    {

        

        public IActionResult Index()
        {
            string cookieValueFromReq = Request.Cookies["curName"];  
            ViewData["curName"] = cookieValueFromReq;
            
            var url = "https://codeforces.com/api/contest.list?gym=false";


            try
            {

                var w = new WebClient();

                string json_data = w.DownloadString(url);

                if (json_data != null)
                {

                    filee con = JsonConvert.DeserializeObject<filee>(json_data);

                    //ViewBag.m = con.result[1].id - 19;
                    return View(con.result);
                }
                else
                {
                    return View(nameof(error_));
                }
            }
            catch (Exception)
            {

            }


            return View(nameof(error_));



        }

        public IActionResult error_()
        {
            return View();
        }


    }
}