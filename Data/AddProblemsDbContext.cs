

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyWebApp.Models;

namespace MyWebApp.Data
{
    public class AddProblemsDbContext : DbContext
    {
        public AddProblemsDbContext(DbContextOptions<AddProblemsDbContext> options)
            : base(options)
        {
        }

        public DbSet<AddProblem> _addProblems {set;get;}

        // public DbSet<userlogin> userlogins {set;get;}

      
    }
}