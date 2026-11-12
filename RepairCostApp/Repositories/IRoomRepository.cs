using RepairCostApp.Entities;

namespace RepairCostApp.Repositories
{
    public interface IRoomRepository
    {
        IEnumerable<Room> ReadRooms();
        Room ReadRoomById(int id);
        void CreateRoom(Room room);
        void UpdateRoom(Room room);
        void DeleteRoom(int id);
    }
}