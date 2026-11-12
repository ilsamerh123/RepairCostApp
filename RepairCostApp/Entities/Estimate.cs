using System;
using System.Collections.Generic;

namespace RepairCostApp.Entities
{
    public class Estimate
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalAmount { get; set; }
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