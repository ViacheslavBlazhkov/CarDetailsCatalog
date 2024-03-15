using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CarDetailsCatalog.Models.Details;

namespace CarDetailsCatalog.Models.Controllers.Repositories
{
    public class EngineRepository
    {
        private readonly DbContext _context;
        private readonly DbSet<Engine> _dbSet;

        public EngineRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<Engine>();
        }

        public List<Engine> GetAll()
        {
            return _dbSet.ToList();
        }

        public List<Engine> GetAllByCarId(int carId)
        {
            return _dbSet.Where(e => e.SuitableCarIds != null && e.SuitableCarIds.Contains(carId.ToString())).ToList();
        }
    }
}