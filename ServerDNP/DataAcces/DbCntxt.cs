using Entities;
using Microsoft.EntityFrameworkCore;


namespace ServerDNP.DataAcces
{
   
    
        public class DbCntxt  : DbContext
        {
            public DbSet<Adult> Adults { get; set; }
            public DbSet<Job> Jobs { get; set; }
            public DbSet<User> Users { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite("Data Source = Adult.db");
            }

        }
    }
