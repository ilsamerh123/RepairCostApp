using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RepairCostApp.Data;
using RepairCostApp.Entities;

namespace RepairCostApp.Repositories.Implementations
{
    internal class EstimateRepository : IEstimateRepository
    {
        private readonly DataContext _context;
        private readonly ILogger<EstimateRepository> _logger;

        public EstimateRepository(DataContext context, ILogger<EstimateRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IEnumerable<Estimate> ReadEstimates(DateTime? dateFrom = null, DateTime? dateTo = null)
        {
            _logger.LogInformation("Получение списка смет");
            // Include(e => e.Items) подтягивает связанные работы из БД
            var query = _context.Estimates.Include(e => e.Items).AsQueryable();

            if (dateFrom.HasValue) query = query.Where(e => e.Date >= dateFrom.Value);
            if (dateTo.HasValue) query = query.Where(e => e.Date <= dateTo.Value);

            return query.ToList();
        }

        public void CreateEstimate(Estimate estimate, IEnumerable<EstimateItem> items)
        {
            _logger.LogInformation("Создание новой сметы на сумму: {Total}", estimate.TotalAmount);

            using var transaction = _context.Database.BeginTransaction();
            try
            {
                _context.Estimates.Add(estimate);
                _context.SaveChanges(); 

                foreach (var item in items)
                {
                    item.EstimateId = estimate.Id;
                    _context.EstimateItems.Add(item);
                }
                _context.SaveChanges();

                transaction.Commit(); 
                _logger.LogInformation("Смета успешно создана с ID: {Id}", estimate.Id);
            }
            catch (Exception ex)
            {
                transaction.Rollback(); 
                _logger.LogError(ex, "Ошибка при создании сметы");
                throw;
            }
        }

        public void DeleteEstimate(int id)
        {
            _logger.LogInformation("Удаление сметы с ID: {Id}", id);
            var estimate = _context.Estimates.Include(e => e.Items).FirstOrDefault(e => e.Id == id);

            if (estimate != null)
            {
                _context.Estimates.Remove(estimate); 
                _context.SaveChanges();
            }
        }
    }
}