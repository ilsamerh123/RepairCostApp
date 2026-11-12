namespace RepairCostApp.Entities
{
    public class Contractor
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string INN { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

        public Contractor() { }

        public static Contractor CreateEntity(int id, string name, string inn, string phone)
        {
            return new Contractor
            {
                Id = id,
                Name = name ?? string.Empty,
                INN = inn ?? string.Empty,
                Phone = phone ?? string.Empty
            };
        }
    }
}
