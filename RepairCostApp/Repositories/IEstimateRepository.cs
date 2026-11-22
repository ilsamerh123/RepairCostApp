using RepairCostApp.Entities;
using System;
using System.Collections.Generic;

namespace RepairCostApp.Repositories
{
    public interface IEstimateRepository
    {
        IEnumerable<Estimate> ReadEstimates(DateTime? dateFrom = null, DateTime? dateTo = null);
        void CreateEstimate(Estimate estimate, IEnumerable<EstimateItem> items);
        void DeleteEstimate(int id);
    }
}