using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace MyWebApp.Models
{
    public class ImageUp
    {
        [Key] 
       //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImageId { get; set; }

        [Display(Name="ImageName")]
        [StringLength(20)]
        [Required(ErrorMessage = "(0) is a required")]
        public string ImageName { get; set; }

        [MaxLength]
        public byte[] Datafiles {get;set;}
        

        // [Display(Name="ImageUrl")]
        // [Required(ErrorMessage = "(0) is a required")]
        // [DataType(DataType.ImageUrl)]
        // public string ImageUrl { get; set; }

    }
}