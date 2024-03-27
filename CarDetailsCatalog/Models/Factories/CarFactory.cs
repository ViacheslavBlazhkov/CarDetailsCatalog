using System.Linq;
using CarDetailsCatalog.Constants;
using CarDetailsCatalog.Exceptions;

namespace CarDetailsCatalog.Models.Factories
{
    public static class CarFactory
    {
        public static Car Create(Brand brand, string model, int year)
        {
            var newCar = new Car
            {
                BrandId = (int)brand,
                Model = model,
                Year = year
            };
            using (var context = new AppDbContext())
            {
                var car = context.Cars.FirstOrDefault(c =>
                    c.BrandId == newCar.BrandId && c.Model == newCar.Model && c.Year == newCar.Year);
                if (car != null)
                {
                    throw new CarAlreadyExistsException();
                }

                context.Cars.Add(newCar);
                context.SaveChanges();
            }

            return newCar;
        }
    }
}