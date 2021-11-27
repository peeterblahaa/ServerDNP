using Microsoft.EntityFrameworkCore;
using ServerDNP.Models;

namespace ServerDNP.DataAcces
{
   
    
        public class DbCntxt  : DbContext
        {
            public DbSet<Adult> Adults { get; set; }
            public DbSet<Job> Jobs { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite("Data Source = Adult.db");
            }

        }
    }
