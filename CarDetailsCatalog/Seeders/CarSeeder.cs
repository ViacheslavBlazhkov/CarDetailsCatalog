using CarDetailsCatalog.Constants;
using CarDetailsCatalog.Models.Factories;

namespace CarDetailsCatalog.Seeders
{
    public static class CarSeeder
    {
        public static void Seed()
        {
            CarFactory.Create(Brand.Audi, "A1", 2010);
            CarFactory.Create(Brand.Audi, "A3", 1996);
            CarFactory.Create(Brand.Audi, "A4", 1994);
            CarFactory.Create(Brand.Bmw, "3 Series", 1975);
            CarFactory.Create(Brand.Bmw, "4 Series", 2014);
            CarFactory.Create(Brand.Bmw, "5 Series", 1972);
            CarFactory.Create(Brand.Porsche, "Boxster", 1996);
            CarFactory.Create(Brand.Porsche, "911", 1964);
            CarFactory.Create(Brand.Subaru, "BRZ", 2012);
        }
    }
}