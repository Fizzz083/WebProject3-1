

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
using System.IO;
using ExcelDataReader;
using System.Web;
using Microsoft.AspNetCore.Http;
using System.Security.Cryptography;



namespace MyWebApp.Models
{
    public class filee
    {
        public string status{get;set;}

        public IList<result> result {get;set;}
    }

   

}