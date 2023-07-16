using Microsoft.EntityFrameworkCore;
using logInApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace logInApp.ViewModel
{
    public class DataContext : DbContext
    {

        //setting the data base tables
        public DbSet<Student> Students { get; set; }

        public string dbPath = @"C:\Users\achal\source\repos\logInApp\logInApp\DtB.db";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite($"Data Source={dbPath}");
    }
}
