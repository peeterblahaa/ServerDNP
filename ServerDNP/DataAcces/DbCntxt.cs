using Microsoft.EntityFrameworkCore;
using ServerDNP.Models;

namespace ServerDNP.DataAcces
{
    public class DbCntxt
    {
        public class AdultDbContext : DbContext
        {
            public DbSet<Job> Jobs { get; set; }
            public DbSet<Adult> Adults { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite("Data Source = Adults.db");
            }

        }
    }
}