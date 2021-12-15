

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyWebApp.Models;

namespace MyWebApp.Data
{
    public class ImagesDbContext : DbContext
    {
        public ImagesDbContext(DbContextOptions<ImagesDbContext> options)
            : base(options)
        {
        }

        public DbSet<ImageUp> __images {set;get;}

        // public DbSet<userlogin> userlogins {set;get;}

      
    }
}