using System.Data.Entity;
using CarDetailsCatalog.Models;

namespace CarDetailsCatalog
{
    public class AppDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Detail> Details { get; set; }
    }
}