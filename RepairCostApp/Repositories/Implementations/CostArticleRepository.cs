using RepairCostApp.Entities;
using System.Collections.Generic;

namespace RepairCostApp.Repositories.Implementations
{
    internal class CostArticleRepository : ICostArticleRepository
    {
        public IEnumerable<CostArticle> ReadCostArticles() => new List<CostArticle>();
        public CostArticle ReadCostArticleById(int id) => CostArticle.CreateEntity(0, "Тест", "шт");
        public void CreateCostArticle(CostArticle article) { }
        public void UpdateCostArticle(CostArticle article) { }
        public void DeleteCostArticle(int id) { }
    }
}