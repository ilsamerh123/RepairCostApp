using RepairCostApp.Entities;

namespace RepairCostApp.Repositories
{
    public interface IContractorRepository
    {
        IEnumerable<Contractor> ReadContractors();
        Contractor ReadContractorById(int id);
        void CreateContractor(Contractor contractor);
        void UpdateContractor(Contractor contractor);
        void DeleteContractor(int id);
    }
}