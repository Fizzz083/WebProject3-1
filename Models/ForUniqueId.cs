using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace MyWebApp.Models
{
    public abstract class GetUniqueId 
    {
        private int id = 10;

        public int getUniqueId()
        {
            return id;
        }
        public void setUniqueId(int a)
        {
            id = a;
        }

    }

    public class HelperClass : GetUniqueId
    {

    }

}