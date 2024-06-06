using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CarDetailsCatalog.Models.Details;

namespace CarDetailsCatalog.Models.Controllers.Repositories
{
    public class GearboxRepository
    {
        private readonly DbSet<Gearbox> _dbSet;

        public GearboxRepository(DbContext context)
        {
            _dbSet = context.Set<Gearbox>();
        }

        public List<Gearbox> GetAll() => _dbSet.ToList();

        public List<Gearbox> GetAllByCarId(int carId) => _dbSet
            .Where(e => e.SuitableCarIds != null && e.SuitableCarIds.Contains(carId.ToString())).ToList();

        public List<Gearbox> SearchByTitle(string title) => _dbSet.Where(e => e.Name.Contains(title)).ToList();
    }
}