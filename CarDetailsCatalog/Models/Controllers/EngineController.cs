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

        public static EngineController Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EngineController(new EngineRepository(new AppDbContext()));
                }

                return _instance;
            }
        }

        public static List<Engine> GetAll()
        {
            return Instance._repository.GetAll();
        }
    }
}