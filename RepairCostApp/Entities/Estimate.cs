using System;
using System.Collections.Generic;

namespace RepairCostApp.Entities
{
    public class Estimate
    {
        public int Id { get; private set; }
        public DateTime Date { get; private set; }
        public decimal TotalAmount { get; private set; }
        public int RoomId { get; private set; }
        public List<EstimateItem> Items { get; private set; } = new List<EstimateItem>();

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