using RepairCostApp.Entities;
using System.Collections.Generic;

namespace RepairCostApp.Repositories.Implementations
{
    internal class ContractorRepository : IContractorRepository
    {
        public IEnumerable<Contractor> ReadContractors() => new List<Contractor>();
        public Contractor ReadContractorById(int id) => Contractor.CreateEntity(0, "Тест", "123", "999");
        public void CreateContractor(Contractor contractor) { }
        public void UpdateContractor(Contractor contractor) { }
        public void DeleteContractor(int id) { }
    }
}