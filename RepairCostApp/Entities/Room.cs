using RepairCostApp.Entities.Enums;

namespace RepairCostApp.Entities
{
    public class Room
    {
        public int Id { get; private set; }
        public string Address { get; private set; } = string.Empty;
        public double Area { get; private set; }
        public RoomType Type { get; private set; }

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
