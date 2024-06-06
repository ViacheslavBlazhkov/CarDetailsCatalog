using System.Collections.Generic;
using CarDetailsCatalog.Models.Controllers.Repositories;
using CarDetailsCatalog.Models.Details;

namespace CarDetailsCatalog.Models.Controllers
{
    public class BrakesController
    {
        private static BrakesController _instance;
        private readonly BrakesRepository _repository;

        public BrakesController(BrakesRepository repository)
        {
            _repository = repository;
        }

        public static BrakesController Instance =>
            _instance ?? (_instance = new BrakesController(new BrakesRepository(new AppDbContext())));

        public List<Brakes> GetAll() => Instance._repository.GetAll();

        public List<Brakes> GetAllByCarId(int carId) => Instance._repository.GetAllByCarId(carId);

        public List<Brakes> SearchByTitle(string title) => Instance._repository.SearchByTitle(title);
    }
}