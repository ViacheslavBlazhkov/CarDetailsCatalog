using System.Collections.Generic;
using CarDetailsCatalog.Models.Controllers.Repositories;
using CarDetailsCatalog.Models.Details;

namespace CarDetailsCatalog.Models.Controllers
{
    public class EngineController
    {
        private static EngineController _instance;
        private readonly EngineRepository _repository;

        private EngineController(EngineRepository repository)
        {
            _repository = repository;
        }

        public static EngineController Instance =>
            _instance ?? (_instance = new EngineController(new EngineRepository(new AppDbContext())));

        public List<Engine> GetAll() => Instance._repository.GetAll();

        public List<Engine> GetAllByCarId(int carId) => Instance._repository.GetAllByCarId(carId);

        public List<Engine> SearchByTitle(string title) => Instance._repository.SearchByTitle(title);
    }
}