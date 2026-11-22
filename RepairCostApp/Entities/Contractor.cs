namespace RepairCostApp.Entities
{
    public class Contractor
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public string INN { get; private set; } = string.Empty;
        public string Phone { get; private set; } = string.Empty;

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
