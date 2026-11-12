using RepairCostApp.Entities;
using System;
using System.Collections.Generic;

namespace RepairCostApp.Repositories
{
    public interface IRepairWorkRepository
    {
        IEnumerable<RepairWork> ReadRepairWorks(DateTime? dateFrom = null, DateTime? dateTo = null);
        void CreateRepairWork(RepairWork work);
        void DeleteRepairWork(int id);
    }
}