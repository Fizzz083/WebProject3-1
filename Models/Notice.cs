using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace MyWebApp.Models
{
    public class Notice
    {
        [Key] 
       //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NId { get; set; }

        [Display(Name="Short Description")]
        [StringLength(200)]
        [Required(ErrorMessage = "(0) is a required")]
        public string ShortDescription { get; set; }


        [Display(Name = "Description")]
        [StringLength(1550)]
        [Required(ErrorMessage = "(0) is a required")]
        public string Description { get; set; }


        [Display(Name = "Time")]
        [StringLength(100)]
        //[Required(ErrorMessage = "(0) is a required")]
        public string Time { get; set; }
    }
}