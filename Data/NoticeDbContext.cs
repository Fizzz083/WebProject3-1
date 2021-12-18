

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyWebApp.Models;

namespace MyWebApp.Data
{
    public class NoticeDbContext : DbContext
    {
        public NoticeDbContext(DbContextOptions<NoticeDbContext> options)
            : base(options)
        {
        }

        public DbSet<Notice> _notices {set;get;}
      
    }
}