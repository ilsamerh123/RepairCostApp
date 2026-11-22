namespace RepairCostApp.Entities
{
    public class CostArticle
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public string Unit { get; private set; } = string.Empty;

        public static CostArticle CreateEntity(int id, string name, string unit)
        {
            return new CostArticle
            {
                Id = id,
                Name = name ?? string.Empty,
                Unit = unit ?? string.Empty
            };
        }
    }
}
