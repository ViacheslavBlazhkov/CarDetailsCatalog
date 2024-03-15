using CarDetailsCatalog.Constants;
using CarDetailsCatalog.Models;
using CarDetailsCatalog.Models.Abstracts;
using CarDetailsCatalog.Models.Controllers;
using CarDetailsCatalog.Models.Details;

namespace CarDetailsCatalog.Seeders.Details
{
    public class EngineSeeder
    {
        private readonly AppDbContext _context;

        public EngineSeeder(AppDbContext context)
        {
            _context = context;
        }

        public void Seed() // engines for Audi A4 1994
        {
            Car audiA41994 = CarController.Instance.FindByBrandAndModel(Brand.Audi, "A4");
            var engines = new[]
            {
                new Engine
                {
                    Name = "1.6L 4AT (101 HP)",
                    ProducerId = (int)Producer.Volkswagen,
                    SuitableCarIds = ADetail.GetSuitableCarIdsStringByArray(new int[] { audiA41994.Id }),
                    Price = 500,
                    HorsePower = 101,
                    Torque = 140,
                    FuelConsumption = 8.8,
                },
                new Engine
                {
                    Name = "1.6L 5MT (101 HP)",
                    ProducerId = (int)Producer.Volkswagen,
                    SuitableCarIds = ADetail.GetSuitableCarIdsStringByArray(new int[] { audiA41994.Id }),
                    Price = 500,
                    HorsePower = 101,
                    Torque = 140,
                    FuelConsumption = 8,
                },
                new Engine
                {
                    Name = "1.8L 4AT (125 HP)",
                    ProducerId = (int)Producer.Volkswagen,
                    SuitableCarIds = ADetail.GetSuitableCarIdsStringByArray(new int[] { audiA41994.Id }),
                    Price = 650,
                    HorsePower = 125,
                    Torque = 173,
                    FuelConsumption = 9.1,
                },
            };

            _context.Engines.AddRange(engines);
            _context.SaveChanges();
        }
    }
}