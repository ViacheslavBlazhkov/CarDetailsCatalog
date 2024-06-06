using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CarDetailsCatalog.Models.Details;

namespace CarDetailsCatalog.Models.Controllers.Repositories
{
    public class BrakesRepository
    {
        private readonly DbSet<Brakes> _dbSet;

        public BrakesRepository(DbContext context)
        {
            _dbSet = context.Set<Brakes>();
        }

        public List<Brakes> GetAll() => _dbSet.ToList();

        public List<Brakes> GetAllByCarId(int carId) => _dbSet
            .Where(e => e.SuitableCarIds != null && e.SuitableCarIds.Contains(carId.ToString())).ToList();

        public List<Brakes> SearchByTitle(string title) => _dbSet.Where(e => e.Name.Contains(title)).ToList();
    }
}