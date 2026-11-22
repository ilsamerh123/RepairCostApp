using RepairCostApp.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RepairCostApp.Repositories.Implementations
{
    internal class CostArticleRepository : ICostArticleRepository
    {
        private static readonly List<CostArticle> _articles = new List<CostArticle>();
        private static int _nextId = 1;

        public IEnumerable<CostArticle> ReadCostArticles() => _articles;
        public CostArticle ReadCostArticleById(int id) => _articles.FirstOrDefault(a => a.Id == id);

        public void CreateCostArticle(CostArticle article)
        {
            var newArticle = CostArticle.CreateEntity(_nextId++, article.Name, article.Unit);
            _articles.Add(newArticle);
        }

        public void UpdateCostArticle(CostArticle article)
        {
            var index = _articles.FindIndex(a => a.Id == article.Id);
            if (index != -1) _articles[index] = article;
        }

        public void DeleteCostArticle(int id)
        {
            var article = _articles.FirstOrDefault(a => a.Id == id);
            if (article != null) _articles.Remove(article);
        }
    }
}