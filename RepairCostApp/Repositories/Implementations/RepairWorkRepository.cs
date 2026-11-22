using RepairCostApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepairCostApp.Repositories.Implementations
{
    internal class RepairWorkRepository : IRepairWorkRepository
    {
        private static readonly List<RepairWork> _works = new List<RepairWork>();
        private static int _nextId = 1;

        public IEnumerable<RepairWork> ReadRepairWorks(DateTime? dateFrom = null, DateTime? dateTo = null)
        {
            var query = _works.AsQueryable();
            if (dateFrom.HasValue) query = query.Where(w => w.Date >= dateFrom.Value);
            if (dateTo.HasValue) query = query.Where(w => w.Date <= dateTo.Value);
            return query.ToList();
        }

        public void CreateRepairWork(RepairWork work)
        {
            var newWork = RepairWork.CreateOperation(_nextId++, work.Date, work.Quantity, work.Price, work.Category, work.RoomId, work.ContractorId, work.CostArticleId);
            _works.Add(newWork);
        }

        public void DeleteRepairWork(int id)
        {
            var work = _works.FirstOrDefault(w => w.Id == id);
            if (work != null) _works.Remove(work);
        }
    }
}