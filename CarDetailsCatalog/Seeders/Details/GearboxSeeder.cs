using CarDetailsCatalog.Constants;
using CarDetailsCatalog.Models;
using CarDetailsCatalog.Models.Abstracts;
using CarDetailsCatalog.Models.Controllers;
using CarDetailsCatalog.Models.Details;

namespace CarDetailsCatalog.Seeders.Details
{
    public class GearboxSeeder
    {
        private readonly AppDbContext _context;

        public GearboxSeeder(AppDbContext context)
        {
            _context = context;
        }

        public void Seed() // engines for Audi A4 1994
        {
            Car audiA41994 = CarController.Instance.FindByBrandAndModel(Brand.Audi, "A4");
            var gearboxes = new[]
            {
                new Gearbox()
                {
                    Name = "ZF 5HP18",
                    ProducerId = (int)Producer.ZfFriedrichshafenAg,
                    SuitableCarIds = ADetail.GetSuitableCarIdsStringByArray(new[] { audiA41994.Id }),
                    Price = 450,
                    Gears = 5,
                    Type = GearboxType.Automatic
                },
                new Gearbox()
                {
                    Name = "Getrag 01A",
                    ProducerId = (int)Producer.Getrag,
                    SuitableCarIds = ADetail.GetSuitableCarIdsStringByArray(new[] { audiA41994.Id }),
                    Price = 350,
                    Gears = 5,
                    Type = GearboxType.Manual
                },
            };

            _context.Gearboxes.AddRange(gearboxes);
            _context.SaveChanges();
        }
    }
}