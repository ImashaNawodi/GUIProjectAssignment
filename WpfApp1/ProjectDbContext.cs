using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using WpfApp1;

namespace project02
{
    public class ProjectDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        public ProjectDbContext()
        {
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string appDataPath = AppDomain.CurrentDomain.BaseDirectory;
            string dbPath = Path.Combine(appDataPath, "studentsss.db");
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }

       
    }
}
