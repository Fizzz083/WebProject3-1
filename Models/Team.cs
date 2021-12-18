using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace MyWebApp.Models
{
    public class Team
    {
        [Key] 
       //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TId { get; set; }

        [Display(Name="Username")]
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


        [Display(Name = "Member1's Email")]
        [StringLength(30)]
        [Required(ErrorMessage = "(0) is a required")]
        public string Email { get; set; }

        [Display(Name = "Member1's Phonenumber")]
        [StringLength(30)]
        [Required(ErrorMessage = "(0) is a required")]
        public string Phonenumber { get; set; }
        }
}