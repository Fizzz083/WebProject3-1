using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace MyWebApp.Models
{
     public class AddProblem
    {
        [Key]
        public int Pid { get; set; }


        [Display(Name="Problem's name")]
        [StringLength(100)]
        [Required(ErrorMessage = "(0) is a required")]
        public string PName { get; set; }

        [Display(Name="Link")]
        [StringLength(1000)]
        [Required(ErrorMessage = "(0) is a required")]
        public string PLink { get; set; }

        [Display(Name="Tag")]
        [StringLength(200)]
        public string PTag { get; set; }

        [Display(Name="Idea")]
        [StringLength(300)]
        public string PIdea { get; set; }

        [Display(Name="Added by")]
        [StringLength(2000)]
        public string PAddedBy { get; set; }

    }

}