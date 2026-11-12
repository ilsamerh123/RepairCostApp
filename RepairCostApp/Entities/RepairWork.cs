using System;
using RepairCostApp.Entities.Enums;
namespace RepairCostApp.Entities
{
    public class RepairWork
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Quantity { get; set; }
        public decimal Price { get; set; }
        public WorkCategory Category { get; set; }
        public int RoomId { get; set; }
        public int ContractorId { get; set; }
        public int CostArticleId { get; set; }

        public RepairWork() { }

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