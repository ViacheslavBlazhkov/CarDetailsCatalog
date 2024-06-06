using CarDetailsCatalog.Constants;
using CarDetailsCatalog.Models;
using CarDetailsCatalog.Models.Controllers;
using CarDetailsCatalog.Models.Factories;

namespace CarDetailsCatalog.Seeders.Details
{
    public static class EngineSeeder
    {
        public static void Seed()
        {
            Car audiA41994 = CarController.Instance.FindByBrandAndModel(Brand.Audi, "A4");
            DetailFactory.CreateEngine(
                "1.6L 4AT (101 HP)",
                Producer.Volkswagen,
                new[] { audiA41994.Id },
                500,
                101,
                140,
                8.8
            );
            DetailFactory.CreateEngine(
                "1.6L 5MT (101 HP)",
                Producer.Volkswagen,
                new[] { audiA41994.Id },
                500,
                101,
                140,
                8
            );
            DetailFactory.CreateEngine(
                "1.8L 4AT (125 HP)",
                Producer.Volkswagen,
                new[] { audiA41994.Id },
                650,
                125,
                173,
                9.1
            );
        }
    }
}