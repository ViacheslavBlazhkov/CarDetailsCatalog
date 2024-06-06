using System.Data.Entity;
using System.Linq;
using CarDetailsCatalog.Models.Abstracts;

namespace CarDetailsCatalog.Models.Controllers.Repositories
{
    public class DetailRepository
    {
        private readonly DbSet<ADetail> _dbSet;

        public DetailRepository(DbContext context)
        {
            _dbSet = context.Set<ADetail>();
        }

        public IDetail FindByName(string name) => _dbSet.FirstOrDefault(d => d.Name == name);
    }
}