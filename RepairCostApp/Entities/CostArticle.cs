namespace RepairCostApp.Entities
{
    public class CostArticle
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Unit { get; set; } = string.Empty;

        public CostArticle() { }

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
