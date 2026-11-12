namespace RepairCostApp.Entities
{
    public class EstimateItem
    {
        public int Id { get; set; }
        public int EstimateId { get; set; }
        public int RepairWorkId { get; set; }
        public string WorkName { get; set; } = string.Empty;

        public EstimateItem() { }

        public static EstimateItem CreateElement(int id, int estimateId, int repairWorkId)
        {
            return new EstimateItem
            {
                Id = id,
                EstimateId = estimateId,
                RepairWorkId = repairWorkId
            };
        }
    }
}