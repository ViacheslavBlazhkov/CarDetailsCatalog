using System.Collections.Generic;
using CarDetailsCatalog.Models.Controllers.Repositories;
using CarDetailsCatalog.Models.Details;

namespace CarDetailsCatalog.Models.Controllers
{
    public class EngineController
    {
        private static EngineController _instance;
        private readonly EngineRepository _repository;

        public EngineController(EngineRepository repository)
        {
            _repository = repository;
        }

        public static EngineController Instance =>
            _instance ?? (_instance = new EngineController(new EngineRepository(new AppDbContext())));

        public List<Engine> GetAll()
        {
            return Instance._repository.GetAll();
        }

        public List<Engine> GetAllByCarId(int carId)
        {
            return Instance._repository.GetAllByCarId(carId);
        }
    }
}