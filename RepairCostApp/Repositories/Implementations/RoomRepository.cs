using RepairCostApp.Data;
using RepairCostApp.Entities;
using RepairCostApp.Entities.Enums;
using System.Collections.Generic;

namespace RepairCostApp.Repositories.Implementations
{
    internal class RoomRepository : IRoomRepository
    {
        private readonly DataContext _context;

        // Внедряем DataContext через конструктор
        public RoomRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Room> ReadRooms()
        {
            // Читаем все помещения из БД
            return _context.Rooms.ToList();
        }
        public Room ReadRoomById(int id)
        {
            // Ищем помещение по ID
            return _context.Rooms.FirstOrDefault(r => r.Id == id);
        }
        public void CreateRoom(Room room)
        {
            // Добавляем в контекст и сохраняем в БД
            _context.Rooms.Add(room);
            _context.SaveChanges();
        }

        public void UpdateRoom(Room room)
        {
            // Обновляем запись в БД
            _context.Rooms.Update(room);
            _context.SaveChanges();
        }

        public void DeleteRoom(int id)
        {
            // Находим и удаляем
            var room = _context.Rooms.FirstOrDefault(r => r.Id == id);
            if (room != null)
            {
                _context.Rooms.Remove(room);
                _context.SaveChanges();
            }
        }
    }
}