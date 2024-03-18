using System.Collections.Generic;
using CarDetailsCatalog.Models.Controllers.Repositories;
using CarDetailsCatalog.Models.Details;

namespace CarDetailsCatalog.Models.Controllers
{
    public class EngineController
    {
        private static EngineController _instance;
        private readonly EngineRepository _repository;
        private readonly DetailRepository _detailRepository;

        public EngineController(EngineRepository repository, DetailRepository detailRepository)
        {
            _repository = repository;
            _detailRepository = detailRepository;
        }

        public static EngineController Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EngineController(
                        new EngineRepository(new AppDbContext()),
                        new DetailRepository(new AppDbContext())
                    );
                }

                return _instance;
            }
        }

        public List<Engine> GetAll()
        {
            return Instance._repository.GetAll();
        }

        public List<Engine> GetAllByCarId(int carId)
        {
            return Instance._repository.GetAllByCarId(carId);
        }

        public Engine FindByName(string name)
        {
            return (Engine)Instance._detailRepository.FindByName(name);
        }
    }
}