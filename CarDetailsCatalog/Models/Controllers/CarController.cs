using System.Collections.Generic;
using CarDetailsCatalog.Constants;
using CarDetailsCatalog.Models.Controllers.Repositories;

namespace CarDetailsCatalog.Models.Controllers
{
    public class CarController
    {
        private static CarController _instance;
        private readonly CarRepository _repository;

        public CarController(CarRepository repository)
        {
            _repository = repository;
        }

        public static CarController Instance =>
            _instance ?? (_instance = new CarController(new CarRepository(new AppDbContext())));

        public Car FindByBrandAndModel(Brand brand, string model)
        {
            return Instance._repository.FindByBrandAndModel(brand, model);
        }

        public List<Car> GetAll()
        {
            return Instance._repository.GetAll();
        }

        public List<Car> GetModelsByBrandId(int brandId)
        {
            return Instance._repository.GetModelsByBrandId(brandId);
        }
    }
}