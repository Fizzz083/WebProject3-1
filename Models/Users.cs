using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace MyWebApp.Models
{
    public class Users
    {
        [Key] 
       //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Display(Name="Username")]
        [StringLength(20)]
        [Required(ErrorMessage = "This can't be empty")]
        public string Name { get; set; }


        [Display(Name = "Full Name")]
        [StringLength(50)]
        [Required(ErrorMessage = "FullName can't be empty")]
        public string FullName { get; set; }


        [Display(Name = "Email")]
        [StringLength(30)]
        [Required(ErrorMessage = "Email cant't be empty")]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        [StringLength(50)]
    
        public string PhoneNUmber { get; set; }

        [Display(Name = "Password")]
        [StringLength(20)]
        [Required(ErrorMessage = "Enter password")]
        public string Password{get;set;}

        [Display(Name = "Codeforces Id")]
        [StringLength(20)]
        public string CfId{get;set;}

        [Display(Name = "LightOj Id")]
        [StringLength(20)]
        public string LightOjId{get;set;}

        [Display(Name = "Codechef Id")]
        [StringLength(20)]
        public string CodechefId{get;set;}

     
    }


    public class UserRating_
    {
        public int rating {get;set;}
        public int friendOfCount {get;set;}
        public string maxRank {get;set;}
        public string  rank {get;set;}
        public string  organization {get;set;}
    }



    public class UserRating
    {
        public string status{get;set;}
        public List<UserRating_>result{get;set;}

    }
}