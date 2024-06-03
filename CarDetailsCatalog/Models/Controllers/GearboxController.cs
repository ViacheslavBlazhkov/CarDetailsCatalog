using System.Collections.Generic;
using CarDetailsCatalog.Models.Controllers.Repositories;
using CarDetailsCatalog.Models.Details;

namespace CarDetailsCatalog.Models.Controllers
{
    public class GearboxController
    {
        private static GearboxController _instance;
        private readonly GearboxRepository _repository;

        public GearboxController(GearboxRepository repository)
        {
            _repository = repository;
        }

        public static GearboxController Instance =>
            _instance ?? (_instance = new GearboxController(new GearboxRepository(new AppDbContext())));

        public List<Gearbox> GetAll() => Instance._repository.GetAll();

        public List<Gearbox> GetAllByCarId(int carId) => Instance._repository.GetAllByCarId(carId);

        public List<Gearbox> SearchByTitle(string title) => Instance._repository.SearchByTitle(title);
    }
}