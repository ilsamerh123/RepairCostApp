using RepairCostApp.Data;
using RepairCostApp.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RepairCostApp.Repositories.Implementations
{
    internal class ContractorRepository : IContractorRepository
    {
        private readonly DataContext _context;

        public ContractorRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Contractor> ReadContractors() => _context.Contractors.ToList();

        public Contractor ReadContractorById(int id) => _context.Contractors.FirstOrDefault(c => c.Id == id) ?? throw new Exception($"Подрядчик с ID {id} не найден");

        public void CreateContractor(Contractor contractor)
        {
            _context.Contractors.Add(contractor);
            _context.SaveChanges();
        }

        public void UpdateContractor(Contractor contractor)
        {
            var existing = _context.Contractors.Find(contractor.Id);
            if (existing is null)
                throw new Exception($"Подрядчик с ID {contractor.Id} не найден");

            _context.Entry(existing).CurrentValues.SetValues(contractor);
            _context.SaveChanges();
        }


        public void DeleteContractor(int id)
        {
            var contractor = _context.Contractors.FirstOrDefault(c => c.Id == id);
            if (contractor != null)
            {
                _context.Contractors.Remove(contractor);
                _context.SaveChanges();
            }
        }
    }
}