

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyWebApp.Models;

namespace MyWebApp.Data
{
    public class TeacherInfoDbContext : DbContext
    {
        public TeacherInfoDbContext(DbContextOptions<TeacherInfoDbContext> options)
            : base(options)
        {
        }

        public DbSet<Teacher> _teachers {set;get;}

        // public DbSet<userlogin> userlogins {set;get;}

      
    }
}