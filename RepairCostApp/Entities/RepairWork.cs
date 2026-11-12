using System;
using RepairCostApp.Entities.Enums;
namespace RepairCostApp.Entities
{
    public class RepairWork
    {
        public int Id { get; private set; }
        public DateTime Date { get; private set; }
        public double Quantity { get; private set; }
        public decimal Price { get; private set; }
        public WorkCategory Category { get; private set; }
        public int RoomId { get; private set; }
        public int ContractorId { get; private set; }
        public int CostArticleId { get; private set; }
        public static RepairWork CreateOperation(int id, DateTime date, double quantity, decimal price, WorkCategory category, int roomId, int contractorId, int costArticleId)
        {
            return new RepairWork
            {
                Id = id,
                Date = date,
                Quantity = quantity,
                Price = price,
                Category = category,
                RoomId = roomId,
                ContractorId = contractorId,
                CostArticleId = costArticleId
            };
        }
    }
}