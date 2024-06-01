using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CountryTaskBackend.Models.Entities;

namespace CountryTaskBackend.Models.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}
