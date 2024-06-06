using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CarDetailsCatalog.Models.Details;

namespace CarDetailsCatalog.Models.Controllers.Repositories
{
    public class TireRepository
    {
        private readonly DbSet<Tire> _dbSet;

        public TireRepository(DbContext context)
        {
            _dbSet = context.Set<Tire>();
        }

        public List<Tire> GetAll() => _dbSet.ToList();

        public List<Tire> GetAllByCarId(int carId) => _dbSet
            .Where(e => e.SuitableCarIds != null && e.SuitableCarIds.Contains(carId.ToString())).ToList();

        public List<Tire> SearchByTitle(string title) => _dbSet.Where(e => e.Name.Contains(title)).ToList();
    }
}