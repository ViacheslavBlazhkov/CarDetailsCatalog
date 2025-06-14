using NUnit.Framework;
using CarDetailsCatalog;
using CarDetailsCatalog.Constants;
using CarDetailsCatalog.Exceptions;
using CarDetailsCatalog.Models.Factories;

namespace MSTests
{
    [TestFixture]
    public class CarFactoryTest
    {
        [SetUp]
        public void SetUp()
        {
            using (var context = new AppDbContext())
            {
                context.Database.ExecuteSqlCommand("DELETE FROM Cars");
            }
        }

        [Test]
        public void CreateNewCar()
        {
            var car = CarFactory.Create(Brand.Audi, "RS6", 2025);
            Assert.NotNull(car);
            Assert.AreEqual((int)Brand.Audi, car.BrandId);
            Assert.AreEqual("RS6", car.Model);
            Assert.AreEqual(2025, car.Year);
        }

        [Test]
        public void CreateDuplicateCar()
        {
            CarFactory.Create(Brand.Audi, "RS6", 2020);
            Assert.Throws<CarAlreadyExistsException>(() => { CarFactory.Create(Brand.Audi, "RS6", 2020); });
        }
    }
}