using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace MyWebApp.Models
{
    public class Archive
    {
        [Key] 
       //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AId { get; set; }

        [Display(Name="Team name")]
        [StringLength(20)]
        [Required(ErrorMessage = "(0) is a required")]
        public string TeamName { get; set; }


        [Display(Name = "Member1's Name")]
        [StringLength(50)]
        [Required(ErrorMessage = "(0) is a required")]
        public string Member1 { get; set; }

        [Display(Name = "Member2's Name")]
        [StringLength(50)]
        [Required(ErrorMessage = "(0) is a required")]
        public string Member2 { get; set; }

        [Display(Name = "Member3's Name")]
        [StringLength(50)]
        [Required(ErrorMessage = "(0) is a required")]
        public string Member3 { get; set; }


        [Display(Name = "Contest Name")]
        [StringLength(1000)]
        [Required(ErrorMessage = "(0) is a required")]
        public string ContestName { get; set; }

        [Display(Name = "Year")]
        [StringLength(30)]
        [Required(ErrorMessage = "(0) is a required")]
        public string Year { get; set; }

        [Display(Name = "position")]
        [StringLength(30)]
        [Required(ErrorMessage = "(0) is a required")]
        public string Position { get; set; }
        }
}