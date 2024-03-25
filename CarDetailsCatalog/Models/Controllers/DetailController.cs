using CarDetailsCatalog.Models.Abstracts;
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

        public static DetailController Instance =>
            _instance ?? (_instance = new DetailController(new DetailRepository(new AppDbContext())));

        public IDetail FindByName(string name)
        {
            return _repository.FindByName(name);
        }
    }
}