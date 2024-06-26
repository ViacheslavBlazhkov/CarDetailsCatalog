﻿using System.Data.Entity;
using CarDetailsCatalog.Models;
using CarDetailsCatalog.Models.Abstracts;
using CarDetailsCatalog.Models.Details;

namespace CarDetailsCatalog
{
    public class AppDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<ADetail> Details { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<Gearbox> Gearboxes { get; set; }
        public DbSet<Tire> Tires { get; set; }
        public DbSet<Brakes> Brakes { get; set; }

        public AppDbContext()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<AppDbContext>());
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasKey(c => c.Id);
            modelBuilder.Entity<Engine>().HasKey(d => d.Id);
            modelBuilder.Entity<Gearbox>().HasKey(d => d.Id);
            modelBuilder.Entity<Brakes>().HasKey(d => d.Id);
            modelBuilder.Entity<Tire>().HasKey(d => d.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}