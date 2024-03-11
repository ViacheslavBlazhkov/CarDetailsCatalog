using CarDetailsCatalog.Constants;

namespace CarDetailsCatalog.Models.Factories
{
    public static class CarFactory
    {
        public static Car Create(Brand brand, string model, int year, Country country)
        {
            var car = new Car
            {
                BrandId = (int)brand,
                Model = model,
                Year = year,
                CountryId = (int)country
            };
            using (var context = new AppDbContext())
            {
                context.Cars.Add(car);
                context.SaveChanges();
            }

            return car;
        }
    }
}