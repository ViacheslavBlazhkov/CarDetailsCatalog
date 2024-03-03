using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CarDetailsCatalog.Models.Controllers.Repositories
{
    public class DetailRepository
    {
        private readonly DbContext _context;
        private readonly DbSet<Detail> _dbSet;

        public DetailRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<Detail>();
        }

        public List<Detail> GetAll()
        {
            return _dbSet.ToList();
        }
    }
}