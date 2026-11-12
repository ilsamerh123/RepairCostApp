using RepairCostApp.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RepairCostApp.Repositories.Implementations
{
    internal class ContractorRepository : IContractorRepository
    {
        private static readonly List<Contractor> _contractors = new List<Contractor>();
        private static int _nextId = 1;

        public IEnumerable<Contractor> ReadContractors() => _contractors;
        public Contractor ReadContractorById(int id) => _contractors.FirstOrDefault(c => c.Id == id);

        public void CreateContractor(Contractor contractor)
        {
            var newContractor = Contractor.CreateEntity(_nextId++, contractor.Name, contractor.INN, contractor.Phone);
            _contractors.Add(newContractor);
        }

        public void UpdateContractor(Contractor contractor)
        {
            var index = _contractors.FindIndex(c => c.Id == contractor.Id);
            if (index != -1) _contractors[index] = contractor;
        }

        public void DeleteContractor(int id)
        {
            var contractor = _contractors.FirstOrDefault(c => c.Id == id);
            if (contractor != null) _contractors.Remove(contractor);
        }
    }
}