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

        public List<Gearbox> GetAll()
        {
            return Instance._repository.GetAll();
        }

        public List<Gearbox> GetAllByCarId(int carId)
        {
            return Instance._repository.GetAllByCarId(carId);
        }
    }
}