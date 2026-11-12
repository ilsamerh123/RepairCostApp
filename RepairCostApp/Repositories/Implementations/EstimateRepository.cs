using RepairCostApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepairCostApp.Repositories.Implementations
{
    internal class EstimateRepository : IEstimateRepository
    {
        private static readonly List<Estimate> _estimates = new List<Estimate>();
        private static int _nextId = 1;

        public IEnumerable<Estimate> ReadEstimates(DateTime? dateFrom = null, DateTime? dateTo = null)
        {
            var query = _estimates.AsQueryable();
            if (dateFrom.HasValue) query = query.Where(e => e.Date >= dateFrom.Value);
            if (dateTo.HasValue) query = query.Where(e => e.Date <= dateTo.Value);
            return query.ToList();
        }

        public void CreateEstimate(Estimate estimate, IEnumerable<EstimateItem> items)
        {
            var newEstimate = Estimate.CreateOperation(_nextId++, estimate.Date, estimate.TotalAmount, estimate.RoomId);
            _estimates.Add(newEstimate);
        }

        public void DeleteEstimate(int id)
        {
            var estimate = _estimates.FirstOrDefault(e => e.Id == id);
            if (estimate != null) _estimates.Remove(estimate);
        }
    }
}