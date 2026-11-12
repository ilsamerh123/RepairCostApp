using RepairCostApp.Entities;
using System;
using System.Collections.Generic;

namespace RepairCostApp.Repositories.Implementations
{
    internal class EstimateRepository : IEstimateRepository
    {
        public IEnumerable<Estimate> ReadEstimates(DateTime? dateFrom = null, DateTime? dateTo = null) => new List<Estimate>();
        public void CreateEstimate(Estimate estimate, IEnumerable<EstimateItem> items) { }
        public void DeleteEstimate(int id) { }
    }
}