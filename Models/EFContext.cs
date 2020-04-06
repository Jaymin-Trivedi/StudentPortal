using Microsoft.EntityFrameworkCore;
using StudentApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.Models
{
    class EFContext : DbContext
    {
        private const string connctionString = "server=localhost\\SQLEXPRESS;Database=StudentDb;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connctionString);
        }

        public DbSet<Student> Students { get; set; }
       
    }
}
