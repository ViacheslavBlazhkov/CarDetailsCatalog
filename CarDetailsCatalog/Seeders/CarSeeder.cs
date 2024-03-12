using CarDetailsCatalog.Constants;
using CarDetailsCatalog.Models;

namespace CarDetailsCatalog.Seeders
{
    public class CarSeeder
    {
        private readonly AppDbContext _context;

        public CarSeeder(AppDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            var cars = new[]
            {
                new Car
                {
                    BrandId = (int)Brand.Audi, 
                    Model = "A1", 
                    Year = 2010, 
                    CountryId = (int)Country.Germany
                },
                new Car
                {
                    BrandId = (int)Brand.Audi, 
                    Model = "A3", 
                    Year = 1996, 
                    CountryId = (int)Country.Germany
                },
                new Car
                {
                    BrandId = (int)Brand.Audi, 
                    Model = "A4", 
                    Year = 1994, 
                    CountryId = (int)Country.Germany
                },
                new Car
                {
                    BrandId = (int)Brand.Audi, 
                    Model = "A5", 
                    Year = 2007, 
                    CountryId = (int)Country.Germany
                },
                new Car
                {
                    BrandId = (int)Brand.Bmw, 
                    Model = "3 Series", 
                    Year = 1975, 
                    CountryId = (int)Country.Germany
                },
                new Car
                {
                    BrandId = (int)Brand.Bmw, 
                    Model = "4 Series", 
                    Year = 2014, 
                    CountryId = (int)Country.Germany
                },
                new Car
                {
                    BrandId = (int)Brand.Bmw, 
                    Model = "5 Series", 
                    Year = 1972, 
                    CountryId = (int)Country.Germany
                },
                new Car
                {
                    BrandId = (int)Brand.Bmw, 
                    Model = "7 Series", 
                    Year = 1977, 
                    CountryId = (int)Country.Germany
                },
                new Car
                {
                    BrandId = (int)Brand.Porsche, 
                    Model = "Boxster", 
                    Year = 1996, 
                    CountryId = (int)Country.Germany
                },
                new Car
                {
                    BrandId = (int)Brand.Porsche, 
                    Model = "911", 
                    Year = 1964, 
                    CountryId = (int)Country.Germany
                },
                new Car
                {
                    BrandId = (int)Brand.Porsche, 
                    Model = "Cayenne", 
                    Year = 2002, 
                    CountryId = (int)Country.Germany
                },
                new Car
                {
                    BrandId = (int)Brand.Porsche, 
                    Model = "Macan", 
                    Year = 2014, 
                    CountryId = (int)Country.Germany
                },
                new Car
                {
                    BrandId = (int)Brand.Subaru, 
                    Model = "BRZ", 
                    Year = 2012, 
                    CountryId = (int)Country.Japan
                },
                new Car
                {
                    BrandId = (int)Brand.Subaru, 
                    Model = "Impreza", 
                    Year = 1992, 
                    CountryId = (int)Country.Japan
                },
                new Car
                {
                    BrandId = (int)Brand.Subaru, 
                    Model = "Legacy", 
                    Year = 1989, 
                    CountryId = (int)Country.Japan
                },
                new Car
                {
                    BrandId = (int)Brand.Subaru, 
                    Model = "Outback", 
                    Year = 1994, 
                    CountryId = (int)Country.Japan
                },
            };

            _context.Cars.AddRange(cars);
            _context.SaveChanges();
        }
    }
}