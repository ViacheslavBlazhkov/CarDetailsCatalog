using System.Collections.Generic;
using CarDetailsCatalog.Models.Controllers.Repositories;
using CarDetailsCatalog.Models.Details;

namespace CarDetailsCatalog.Models.Controllers
{
    public class GearboxController
    {
        private static GearboxController _instance;
        private readonly GearboxRepository _repository;
        private readonly DetailRepository _detailRepository;

        public GearboxController(GearboxRepository repository, DetailRepository detailRepository)
        {
            _repository = repository;
            _detailRepository = detailRepository;
        }

        public static GearboxController Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GearboxController(
                        new GearboxRepository(new AppDbContext()),
                        new DetailRepository(new AppDbContext())
                    );
                }

                return _instance;
            }
        }

        public List<Gearbox> GetAll()
        {
            return Instance._repository.GetAll();
        }

        public List<Gearbox> GetAllByCarId(int carId)
        {
            return Instance._repository.GetAllByCarId(carId);
        }

        public Gearbox FindByName(string name)
        {
            return (Gearbox)Instance._detailRepository.FindByName(name);
        }
    }
}