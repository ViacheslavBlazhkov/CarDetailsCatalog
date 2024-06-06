using System.Collections.Generic;
using CarDetailsCatalog.Models.Controllers.Repositories;
using CarDetailsCatalog.Models.Details;

namespace CarDetailsCatalog.Models.Controllers
{
    public class TireController
    {
        private static TireController _instance;
        private readonly TireRepository _repository;

        public TireController(TireRepository repository)
        {
            _repository = repository;
        }

        public static TireController Instance =>
            _instance ?? (_instance = new TireController(new TireRepository(new AppDbContext())));

        public List<Tire> GetAll() => Instance._repository.GetAll();

        public List<Tire> GetAllByCarId(int carId) => Instance._repository.GetAllByCarId(carId);

        public List<Tire> SearchByTitle(string title) => Instance._repository.SearchByTitle(title);
    }
}