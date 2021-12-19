using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace MyWebApp.Models
{
    
    public class Teacher
    {
        [Key] 
       //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name="Teacher's username")]
        [StringLength(20)]
        [Required(ErrorMessage = "(0) is a required")]
        public string Name { get; set; }


        [Display(Name = "Full Name")]
        [StringLength(150)]
        [Required(ErrorMessage = "(0) is a required")]
        public string FullName { get; set; }


        [Display(Name = "Email")]
        [StringLength(30)]
        [Required(ErrorMessage = "(0) is a required")]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        [StringLength(50)]
    
        public string PhoneNUmber { get; set; }
    }

    public class CollectionDataModel
        {
            public List<Teacher> Teachers { get; set; }
            public List<Notice> Notices { get; set; }

            public List<Team> Teams {get; set;}
            public List<Archive> Archives {get;set;}

            public List<ImageUp> Images {get;set;}
        }
}