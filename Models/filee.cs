

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


namespace MyWebApp.Models
{
    public class filee
    {
        public string status{get;set;}

        public IList<result> result {get;set;}
    }
}