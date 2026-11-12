using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RepairCostApp.Data;
using RepairCostApp.Entities;

namespace RepairCostApp.Repositories.Implementations
{
    internal class EstimateRepository : IEstimateRepository
    {
        public IEnumerable<Estimate> ReadEstimates(DateTime? dateFrom = null, DateTime? dateTo = null) => new List<Estimate>();
        public void CreateEstimate(Estimate estimate, IEnumerable<EstimateItem> items) { }
        public void DeleteEstimate(int id) { }
    }
}