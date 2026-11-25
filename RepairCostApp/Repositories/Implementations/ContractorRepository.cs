using Microsoft.Extensions.Logging;
using RepairCostApp.Data;
using RepairCostApp.Entities;

namespace RepairCostApp.Repositories.Implementations
{
    internal class ContractorRepository : IContractorRepository
    {
        private readonly DataContext _context;
        private readonly ILogger<ContractorRepository> _logger;

        public ContractorRepository(DataContext context, ILogger<ContractorRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
        public IEnumerable<Contractor> ReadContractors() => _context.Contractors.OrderBy(c => c.Id).ToList();

        public Contractor ReadContractorById(int id) => _context.Contractors.FirstOrDefault(c => c.Id == id) ?? throw new Exception($"Подрядчик с ID {id} не найден");

        public void CreateContractor(Contractor contractor)
        {
            _logger.LogInformation($"Добавление нового подрядчика: {contractor.Name}", contractor.Name);
            _context.Contractors.Add(contractor);
            _context.SaveChanges();
        }

        public void UpdateContractor(Contractor contractor)
        {
            _logger.LogInformation($"Обновление подрядчика с ID: {contractor.Id}", contractor.Id);
            var existing = _context.Contractors.Find(contractor.Id);
            if (existing is null)
                throw new Exception($"Подрядчик с ID {contractor.Id} не найден");

            _context.Entry(existing).CurrentValues.SetValues(contractor);
            _context.SaveChanges();
        }


        public void DeleteContractor(int id)
        {
            _logger.LogInformation($"Удаление подрядчика с ID: {id}", id);
            var contractor = _context.Contractors.FirstOrDefault(c => c.Id == id);
            if (contractor != null)
            {
                _context.Contractors.Remove(contractor);
                _context.SaveChanges();
            }
        }
    }
}