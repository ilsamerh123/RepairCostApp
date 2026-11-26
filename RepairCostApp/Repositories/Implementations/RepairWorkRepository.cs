using Microsoft.Extensions.Logging;
using RepairCostApp.Data;
using RepairCostApp.Entities;

namespace RepairCostApp.Repositories.Implementations
{
    internal class RepairWorkRepository : IRepairWorkRepository
    {
        private readonly DataContext _context;
        private readonly ILogger<RepairWorkRepository> _logger;

        public RepairWorkRepository(DataContext context, ILogger<RepairWorkRepository> logger)
        {
            _context = context;
            _logger = logger;
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
            _logger.LogInformation($"Добавление ремонтной работы: {work.Category}", work.Category);
            _context.RepairWorks.Add(work);
            _context.SaveChanges();
        }

        public void DeleteRepairWork(int id)
        {
            _logger.LogInformation($"Удаление ремонтной работы: {id}", id);
            var work = _context.RepairWorks.FirstOrDefault(w => w.Id == id);
            if (work != null)
            {
                _context.RepairWorks.Remove(work);
                _context.SaveChanges();
            }
        }
    }
}