using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RepairCostApp.Data;
using RepairCostApp.Entities;

namespace RepairCostApp.Repositories.Implementations
{
    internal class RoomRepository : IRoomRepository
    {
        private readonly DataContext _context;
        private readonly ILogger<RoomRepository> _logger;

        public RoomRepository(DataContext context, ILogger<RoomRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IEnumerable<Room> ReadRooms()
        {
            _logger.LogInformation("Получение списка всех помещений");
            return _context.Rooms.AsNoTracking().OrderBy(r => r.Id).ToList();
        }

        public Room ReadRoomById(int id) => _context.Rooms.FirstOrDefault(r => r.Id == id) ?? throw new Exception($"Помещение с ID {id} не найдено");

        public void CreateRoom(Room room)
        {
            _logger.LogInformation($"Добавление нового помещения: {room.Address}", room.Address);
            _context.Rooms.Add(room);
            _context.SaveChanges();
            _context.ChangeTracker.Clear();
        }

        public void UpdateRoom(Room room)
        {
            _logger.LogInformation($"Обновление помещения с ID: {room.Id}", room.Id);

            var existing = _context.Rooms.Find(room.Id);
            if (existing is null)
                throw new Exception($"Помещение с ID {room.Id} не найдено");
            _context.Entry(existing).CurrentValues.SetValues(room);
            _context.SaveChanges();
            _context.ChangeTracker.Clear();
        }


        public void DeleteRoom(int id)
        {
            _logger.LogInformation($"Удаление помещения с ID: {id}", id);
            var room = _context.Rooms.FirstOrDefault(r => r.Id == id);
            if (room != null)
            {
                _context.Rooms.Remove(room);
                _context.SaveChanges();
                _context.ChangeTracker.Clear();
            }
        }
    }
}