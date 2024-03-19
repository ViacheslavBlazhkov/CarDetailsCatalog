﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CarDetailsCatalog.Models.Details;

namespace CarDetailsCatalog.Models.Controllers.Repositories
{
    public class GearboxRepository
    {
        private readonly DbContext _context;
        private readonly DbSet<Gearbox> _dbSet;

        public GearboxRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<Gearbox>();
        }

        public List<Gearbox> GetAll()
        {
            return _dbSet.ToList();
        }

        public List<Gearbox> GetAllByCarId(int carId)
        {
            return _dbSet.Where(e => e.SuitableCarIds != null && e.SuitableCarIds.Contains(carId.ToString())).ToList();
        }
    }
}