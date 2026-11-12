using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepairCostApp.Entities
{
    public class Estimate
    {
        [Key]
        public int Id { get; set; }

        [Column("date")]
        public DateTime Date { get; set; }

        [Column("totalamount")]
        public decimal TotalAmount { get; set; }

        [Required]
        [Column("roomid")]
        public int RoomId { get; set; }

        public List<EstimateItem> Items { get; set; } = new List<EstimateItem>();

        public Estimate() { }

        public static Estimate CreateOperation(int id, DateTime date, decimal totalAmount, int roomId)
        {
            return new Estimate
            {
                Id = id,
                Date = date,
                TotalAmount = totalAmount,
                RoomId = roomId
            };
        }
    }
}