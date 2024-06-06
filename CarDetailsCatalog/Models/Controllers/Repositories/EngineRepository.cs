using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CarDetailsCatalog.Models.Details;

namespace CarDetailsCatalog.Models.Controllers.Repositories
{
    public class EngineRepository
    {
        private readonly DbSet<Engine> _dbSet;

        public EngineRepository(DbContext context)
        {
            _dbSet = context.Set<Engine>();
        }

        public List<Engine> GetAll() => _dbSet.ToList();

        public List<Engine> GetAllByCarId(int carId) => _dbSet
            .Where(e => e.SuitableCarIds != null && e.SuitableCarIds.Contains(carId.ToString())).ToList();

        public List<Engine> SearchByTitle(string title) => _dbSet.Where(e => e.Name.Contains(title)).ToList();
    }
}