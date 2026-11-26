using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RepairCostApp.Entities.Enums;

namespace RepairCostApp.Entities
{
    public class Room
    {
        [Key] 
        public int Id { get; set; }

        [Required] 
        [Column("address")] 
        public string Address { get; set; } = string.Empty;

        [Column("area")]
        public double Area { get; set; }

        [Column("type")]
        public RoomType Type { get; set; }

        public Room() { }

        public static Room CreateEntity(int id, string address, double area, RoomType type)
        {
            return new Room
            {
                Id = id,
                Address = address ?? string.Empty,
                Area = area,
                Type = type
            };
        }
    }
}