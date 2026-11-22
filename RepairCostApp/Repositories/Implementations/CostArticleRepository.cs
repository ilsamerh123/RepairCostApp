using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using RepairCostApp.Data;
using RepairCostApp.Entities;

namespace RepairCostApp.Repositories.Implementations
{
    internal class CostArticleRepository : ICostArticleRepository
    {
        private readonly DataContext _context;

        public CostArticleRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<CostArticle> ReadCostArticles() => _context.CostArticles.ToList();
        public CostArticle ReadCostArticleById(int id) => _context.CostArticles.FirstOrDefault(c => c.Id == id) ?? throw new Exception($"Статья затрат с ID {id} не найдена");


        public void CreateCostArticle(CostArticle article)
        {
            _context.CostArticles.Add(article);
            _context.SaveChanges();
        }

        public void UpdateCostArticle(CostArticle article)
        {
            var existing = _context.CostArticles.Find(article.Id);

            if (existing is null)
                throw new Exception($"Статья с ID {article.Id} не найдена");
            _context.Entry(existing).CurrentValues.SetValues(article);
            _context.SaveChanges();
        }

        public void DeleteCostArticle(int id)
        {
            var article = _context.CostArticles.FirstOrDefault(c => c.Id == id);
            if (article != null)
            {
                _context.CostArticles.Remove(article);
                _context.SaveChanges();
            }
        }
    }
}