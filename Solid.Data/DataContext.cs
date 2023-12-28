using DotenetProject.Solid.Core.Enitities;
using Microsoft.EntityFrameworkCore;

namespace DotenetProject.Solid.Data
{
    public class DataContext: DbContext
    {
        public DbSet<Order> orders { get; set; }
        public DbSet<Taxi> taxies { get; set; }
        public DbSet<Driver> drivers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=racheli_db");
        }

    }
}
