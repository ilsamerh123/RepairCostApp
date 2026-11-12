using RepairCostApp.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RepairCostApp.Repositories.Implementations
{
    internal class RoomRepository : IRoomRepository
    {
        
        private static readonly List<Room> _rooms = new List<Room>();
        private static int _nextId = 1;

        public IEnumerable<Room> ReadRooms() => _rooms;
        public Room ReadRoomById(int id) => _rooms.FirstOrDefault(r => r.Id == id);

        public void CreateRoom(Room room)
        {
            var newRoom = Room.CreateEntity(_nextId++, room.Address, room.Area, room.Type);
            _rooms.Add(newRoom);
        }

        public void UpdateRoom(Room room)
        {
            var index = _rooms.FindIndex(r => r.Id == room.Id);
            if (index != -1) _rooms[index] = room;
        }

        public void DeleteRoom(int id)
        {
            var room = _rooms.FirstOrDefault(r => r.Id == id);
            if (room != null) _rooms.Remove(room);
        }
    }
}