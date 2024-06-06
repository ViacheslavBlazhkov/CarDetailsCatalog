using CarDetailsCatalog.Constants;
using CarDetailsCatalog.Models;
using CarDetailsCatalog.Models.Controllers;
using CarDetailsCatalog.Models.Factories;

namespace CarDetailsCatalog.Seeders.Details
{
    public static class GearboxSeeder
    {
        public static void Seed()
        {
            Car audiA41994 = CarController.Instance.FindByBrandAndModel(Brand.Audi, "A4");
            DetailFactory.CreateGearbox(
                "ZF 5HP18",
                Producer.ZfFriedrichshafenAg,
                new[] { audiA41994.Id },
                450,
                GearboxType.Automatic,
                5
            );
            DetailFactory.CreateGearbox(
                "Getrag 01A",
                Producer.Getrag,
                new[] { audiA41994.Id },
                350,
                GearboxType.Automatic,
                5
            );
        }
    }
}