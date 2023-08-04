using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Ex2
{
    class DatabaseContext : DbContext
    {
        public DbSet<EFLesson1.Product> Products { get; set; }
        public DatabaseContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb;Database = Lesson1DB; Trusted_connection = true;");
        }
    }
}
