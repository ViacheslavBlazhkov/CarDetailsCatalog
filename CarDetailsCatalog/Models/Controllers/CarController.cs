using System.Collections.Generic;
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

        public static CarController Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CarController(new CarRepository(new AppDbContext()));
                }

                return _instance;
            }
        }

        public static List<Car> GetAll()
        {
            return Instance._repository.GetAll();
        }
    }
}