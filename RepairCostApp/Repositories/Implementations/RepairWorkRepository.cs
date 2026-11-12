using RepairCostApp.Entities;
using System;
using System.Collections.Generic;

namespace RepairCostApp.Repositories.Implementations
{
    internal class RepairWorkRepository : IRepairWorkRepository
    {
        public IEnumerable<RepairWork> ReadRepairWorks(DateTime? dateFrom = null, DateTime? dateTo = null) => new List<RepairWork>();
        public void CreateRepairWork(RepairWork work) { }
        public void DeleteRepairWork(int id) { }
    }
}