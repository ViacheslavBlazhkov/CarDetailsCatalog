using System.Data.Entity;
using CarDetailsCatalog.Models;
using CarDetailsCatalog.Models.Details;

namespace CarDetailsCatalog
{
    public class AppDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Engine> Engines { get; set; }

        public AppDbContext()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<AppDbContext>());
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasKey(c => c.Id);
            modelBuilder.Entity<Engine>().HasKey(d => d.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}