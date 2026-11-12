using RepairCostApp.Entities;

namespace RepairCostApp.Repositories
{
    public interface ICostArticleRepository
    {
        IEnumerable<CostArticle> ReadCostArticles();
        CostArticle ReadCostArticleById(int id);
        void CreateCostArticle(CostArticle article);
        void UpdateCostArticle(CostArticle article);
        void DeleteCostArticle(int id);
    }
}