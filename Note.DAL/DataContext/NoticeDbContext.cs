using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Note.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Note.DAL.DataContext
{
    class NoticeDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public DbSet<Notice> Notices { get; set; }

        public NoticeDbContext(IConfiguration configuration)
        {
            _configuration = configuration; 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("LocalDb"));
        }
    }
}
