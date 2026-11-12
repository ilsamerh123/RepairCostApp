using RepairCostApp.Data;
using RepairCostApp.Entities;
using System.Collections.Generic;
using System.Linq;

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
        public CostArticle ReadCostArticleById(int id) => _context.CostArticles.FirstOrDefault(c => c.Id == id);

        public void CreateCostArticle(CostArticle article)
        {
            _context.CostArticles.Add(article);
            _context.SaveChanges();
        }

        public void UpdateCostArticle(CostArticle article)
        {
            _context.CostArticles.Update(article);
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