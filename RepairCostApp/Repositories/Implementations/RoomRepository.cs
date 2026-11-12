using RepairCostApp.Entities;
using RepairCostApp.Entities.Enums;
using System.Collections.Generic;

namespace RepairCostApp.Repositories.Implementations
{
    internal class RoomRepository : IRoomRepository
    {
        public IEnumerable<Room> ReadRooms() => new List<Room>();
        public Room ReadRoomById(int id) => Room.CreateEntity(0, "Тестовый адрес", 0, RoomType.Apartment);
        public void CreateRoom(Room room) { }
        public void UpdateRoom(Room room) { }
        public void DeleteRoom(int id) { }
    }
}