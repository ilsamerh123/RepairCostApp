using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RepairCostApp.Entities.Enums;

namespace RepairCostApp.Entities
{
    public class RepairWork
    {
        [Key]
        public int Id { get; set; }

        [Column("date")]
        public DateTime Date { get; set; }

        [Column("quantity")]
        public double Quantity { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("category")]
        public WorkCategory Category { get; set; }

        [Required]
        [Column("roomid")]
        public int RoomId { get; set; }

        [Required]
        [Column("contractorid")]
        public int ContractorId { get; set; }

        [Required]
        [Column("costarticleid")]
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