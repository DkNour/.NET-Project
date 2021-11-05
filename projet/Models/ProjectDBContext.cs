using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet.Models
{
    class ProjectDBContext: DbContext
    {
        public DbSet<Admin> Admin { get; set; }
        public DbSet<MovieDB> MoviesDb { get; set; }
        public object MoviesDB { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-IJDTTS2;Database=ProjectDB;Trusted_Connection=True;");
        }
    }
}
