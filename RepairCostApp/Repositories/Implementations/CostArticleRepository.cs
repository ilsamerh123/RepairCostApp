using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RepairCostApp.Data;
using RepairCostApp.Entities;

namespace RepairCostApp.Repositories.Implementations
{
    internal class CostArticleRepository : ICostArticleRepository
    {
        private readonly DataContext _context;
        private readonly ILogger<CostArticle> _logger;

        public CostArticleRepository(DataContext context, ILogger<CostArticle> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IEnumerable<CostArticle> ReadCostArticles() => _context.CostArticles.AsNoTracking().OrderBy(c => c.Id).ToList();
        public CostArticle ReadCostArticleById(int id) => _context.CostArticles.FirstOrDefault(c => c.Id == id) ?? throw new Exception($"Статья затрат с ID {id} не найдена");


        public void CreateCostArticle(CostArticle article)
        {
            _logger.LogInformation($"Добавление новой статьи: {article.Name}", article.Name);
            _context.CostArticles.Add(article);
            _context.SaveChanges();
            _context.ChangeTracker.Clear();
        }

        public void UpdateCostArticle(CostArticle article)
        {
            _logger.LogInformation($"Обновление статьи с ID: {article.Id}", article.Id);
            var existing = _context.CostArticles.Find(article.Id);

            if (existing is null)
                throw new Exception($"Статья с ID {article.Id} не найдена");
            _context.Entry(existing).CurrentValues.SetValues(article);
            _context.SaveChanges();
            _context.ChangeTracker.Clear();
        }

        public void DeleteCostArticle(int id)
        {
            _logger.LogInformation($"Удаление статьи с ID: {id}", id);
            var article = _context.CostArticles.FirstOrDefault(c => c.Id == id);
            if (article != null)
            {
                _context.CostArticles.Remove(article);
                _context.SaveChanges();
                _context.ChangeTracker.Clear();
            }
        }
    }
}