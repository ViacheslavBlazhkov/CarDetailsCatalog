using System.Collections.Generic;
using CarDetailsCatalog.Models.Controllers.Repositories;

namespace CarDetailsCatalog.Models.Controllers
{
    public class DetailController
    {
        private static DetailController _instance;
        private readonly DetailRepository _repository;

        public DetailController(DetailRepository repository)
        {
            _repository = repository;
        }

        public static DetailController Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DetailController(new DetailRepository(new AppDbContext()));
                }

                return _instance;
            }
        }

        public static List<Detail> GetAll()
        {
            return Instance._repository.GetAll();
        }
    }
}