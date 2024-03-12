using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CarDetailsCatalog.Models.Controllers.Repositories
{
    public class CarRepository
    {
        private readonly DbContext _context;
        private readonly DbSet<Car> _dbSet;

        public CarRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<Car>();
        }

        public List<Car> GetAll()
        {
            return _dbSet.ToList();
        }

        public List<Car> GetModelsByBrandId(int brandId)
        {
            return _dbSet.Where(car => car.BrandId == brandId).ToList();
        }
    }
}