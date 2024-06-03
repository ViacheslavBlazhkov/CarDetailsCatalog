using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CarDetailsCatalog.Constants;

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

        public Car FindByBrandAndModel(Brand brand, string model) =>
            _dbSet.FirstOrDefault(car => car.BrandId == (int)brand && car.Model == model);

        public List<Car> GetAll() => _dbSet.ToList();

        public List<Car> GetModelsByBrandId(int brandId) => _dbSet.Where(car => car.BrandId == brandId).ToList();
    }
}