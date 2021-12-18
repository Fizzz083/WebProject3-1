

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyWebApp.Models;

namespace MyWebApp.Data
{
    public class TeamDbContext : DbContext
    {
        public TeamDbContext(DbContextOptions<TeamDbContext> options)
            : base(options)
        {
        }

        public DbSet<Team> _teams {set;get;}

        // public DbSet<userlogin> userlogins {set;get;}

      
    }
}