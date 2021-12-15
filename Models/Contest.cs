using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace MyWebApp.Models
{
     public class result
    {
        public int id { get; set; }
        public string name { get; set; }

        public string type { get; set; }
        public string phase { get; set; }
        public bool frozen { get; set; }

        public int durationSeconds { get; set; }

        public int startTimeSeconds { get; set; }
        public int relativeTimeSeconds { get; set; }


    }

}