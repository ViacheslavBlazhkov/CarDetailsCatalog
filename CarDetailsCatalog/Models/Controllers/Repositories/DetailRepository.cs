using System.Data.Entity;
using System.Linq;
using CarDetailsCatalog.Models.Abstracts;

namespace CarDetailsCatalog.Models.Controllers.Repositories
{
    public class DetailRepository
    {
        private readonly DbContext _context;
        private readonly DbSet<ADetail> _dbSet;

        public DetailRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<ADetail>();
        }

        public ADetail FindByName(string name)
        {
            return _dbSet.FirstOrDefault(d => d.Name == name);
        }
    }
}