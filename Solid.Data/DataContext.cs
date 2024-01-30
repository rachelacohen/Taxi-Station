using DotenetProject.Solid.Core.Enitities;
using Microsoft.EntityFrameworkCore;

namespace DotenetProject.Solid.Data
{
    public class DataContext: DbContext
    {
        public DbSet<Order> Orderrs { get; set; }
        public DbSet<Taxi> Taxiies { get; set; }
        public DbSet<Driver> Driivers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=rachel_db");
        }

    }
}
