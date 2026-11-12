using RepairCostApp.Data;
using RepairCostApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepairCostApp.Repositories.Implementations
{
    internal class RepairWorkRepository : IRepairWorkRepository
    {
        private readonly DataContext _context;

        public RepairWorkRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<RepairWork> ReadRepairWorks(DateTime? dateFrom = null, DateTime? dateTo = null)
        {
            var query = _context.RepairWorks.AsQueryable();
            if (dateFrom.HasValue) query = query.Where(w => w.Date >= dateFrom.Value);
            if (dateTo.HasValue) query = query.Where(w => w.Date <= dateTo.Value);
            return query.ToList();
        }

        public void CreateRepairWork(RepairWork work)
        {
            _context.RepairWorks.Add(work);
            _context.SaveChanges();
        }

        public void DeleteRepairWork(int id)
        {
            var work = _context.RepairWorks.FirstOrDefault(w => w.Id == id);
            if (work != null)
            {
                _context.RepairWorks.Remove(work);
                _context.SaveChanges();
            }
        }
    }
}