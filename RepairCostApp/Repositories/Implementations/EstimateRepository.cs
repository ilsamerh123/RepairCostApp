using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RepairCostApp.Data;
using RepairCostApp.Entities;

namespace RepairCostApp.Repositories.Implementations
{
    internal class EstimateRepository : IEstimateRepository
    {
        private readonly DataContext _context;

        public EstimateRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Estimate> ReadEstimates(DateTime? dateFrom = null, DateTime? dateTo = null)
        {
            // Читаем сметы вместе с их элементами 
            // Include нужен, чтобы подгрузить связанные данные (EstimateItems)
            var query = _context.Estimates.Include(e => e.Items).AsQueryable();

            if (dateFrom.HasValue) query = query.Where(e => e.Date >= dateFrom.Value);
            if (dateTo.HasValue) query = query.Where(e => e.Date <= dateTo.Value);

            return query.ToList();
        }

        public void CreateEstimate(Estimate estimate, IEnumerable<EstimateItem> items)
        {
            // Открываем транзакцию
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                //Сохраняем саму смету
                _context.Estimates.Add(estimate);
                _context.SaveChanges(); // После этого у estimate.Id появится значение из БД

                //Сохраняем элементы сметы (связь многие-ко-многим)
                foreach (var item in items)
                {
                    // Привязываем элемент к только что созданной смете
                    item.EstimateId = estimate.Id;
                    _context.EstimateItems.Add(item);
                }
                _context.SaveChanges();

                // Если всё прошло успешно — фиксируем транзакцию
                transaction.Commit();
            }
            catch (Exception)
            {
                // Если произошла ошибка — откатываем все изменения
                transaction.Rollback();
                throw;
            }
        }

        public void DeleteEstimate(int id)
        {
            var estimate = _context.Estimates.FirstOrDefault(e => e.Id == id);
            if (estimate != null)
            {
                _context.Estimates.Remove(estimate);
                _context.SaveChanges();
            }
        }
    }
}