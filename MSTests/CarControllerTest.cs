using System.Linq;
using NUnit.Framework;
using CarDetailsCatalog;
using CarDetailsCatalog.Models;
using CarDetailsCatalog.Models.Controllers;
using CarDetailsCatalog.Models.Controllers.Repositories;
using CarDetailsCatalog.Constants;

namespace MSTests
{
    [TestFixture]
    public class CarControllerTest
    {
        private AppDbContext _context;
        private CarController _controller;

        [SetUp]
        public void SetUp()
        {
            _context = new AppDbContext();
            _context.Database.ExecuteSqlCommand("DELETE FROM Cars");

            var repo = new CarRepository(_context);
            _controller = new CarController(repo);
        }

        [Test]
        public void FindByBrandAndModel_ReturnsCorrectCar()
        {
            var car = new Car { BrandId = (int)Brand.Audi, Model = "RS6", Year = 2025 };
            _context.Cars.Add(car);
            _context.SaveChanges();

            var result = _controller.FindByBrandAndModel(Brand.Audi, "RS6");

            Assert.NotNull(result);
            Assert.AreEqual("RS6", result.Model);
        }

        [Test]
        public void GetAll_ReturnsAllCars()
        {
            _context.Cars.Add(new Car { BrandId = (int)Brand.Audi, Model = "RS7", Year = 2020 });
            _context.Cars.Add(new Car { BrandId = (int)Brand.Audi, Model = "RS6", Year = 2021 });
            _context.SaveChanges();

            var result = _controller.GetAll();

            Assert.AreEqual(2, result.Count);
        }

        [Test]
        public void GetModelsByBrandId_ReturnsOnlyMatchingBrand()
        {
            _context.Cars.Add(new Car { BrandId = (int)Brand.Audi, Model = "RS8", Year = 2018 });
            _context.Cars.Add(new Car { BrandId = (int)Brand.Audi, Model = "S8", Year = 2019 });
            _context.Cars.Add(new Car { BrandId = (int)Brand.Bmw, Model = "i8", Year = 2019 });
            _context.SaveChanges();

            var result = _controller.GetModelsByBrandId((int)Brand.Audi);

            Assert.AreEqual(2, result.Count);
            Assert.IsTrue(result.All(c => c.BrandId == (int)Brand.Audi));
        }
    }
}