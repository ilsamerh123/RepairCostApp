using RepairCostApp.Entities.Enums;

namespace RepairCostApp.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public string Address { get; set; } = string.Empty;
        public double Area { get; set; }
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
