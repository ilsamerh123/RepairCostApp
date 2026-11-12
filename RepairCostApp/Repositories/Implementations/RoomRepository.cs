using Microsoft.Extensions.Logging;
using RepairCostApp.Data;
using RepairCostApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

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
            return _context.Rooms.ToList();
        }

        public Room ReadRoomById(int id)
        {
            _logger.LogInformation("Поиск помещения по ID: {Id}", id);
            return _context.Rooms.FirstOrDefault(r => r.Id == id);
        }

        public void CreateRoom(Room room)
        {
            _logger.LogInformation("Добавление нового помещения: {Address}", room.Address);
            _context.Rooms.Add(room);
            _context.SaveChanges();
        }

        public void UpdateRoom(Room room)
        {
            _logger.LogInformation("Обновление помещения с ID: {Id}", room.Id);
            _context.Rooms.Update(room);
            _context.SaveChanges();
        }

        public void DeleteRoom(int id)
        {
            _logger.LogInformation("Удаление помещения с ID: {Id}", id);
            var room = _context.Rooms.FirstOrDefault(r => r.Id == id);
            if (room != null)
            {
                _context.Rooms.Remove(room);
                _context.SaveChanges();
            }
        }
    }
}