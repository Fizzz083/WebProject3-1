using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;


namespace MyWebApp.Models
{
    public class Resource
    {
        [Key] 
        public int RId { get; set; }

        [Display(Name="Short Description")]
        [StringLength(1000)]
        public string ShortDescription { get; set; }

        [Display(Name="Description")]
        [StringLength(10000)]
        public string Description { get; set; }


        [Display(Name = "Added By")]
        [StringLength(50)]
        public string AddedBy { get; set; }


        [Display(Name = "Topic")]
        [StringLength(1000)]
        //[Required(ErrorMessage = "(0) is a required")]
        public string Topic { get; set; }

        [MaxLength]
        public byte[] Datafiles {get;set;}
    }
}