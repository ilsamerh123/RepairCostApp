namespace RepairCostApp.Entities
{
    public class EstimateItem
    {
        public int Id { get; private set; }
        public int EstimateId { get; private set; }
        public int RepairWorkId { get; private set; }
        public string WorkName { get; private set; } = string.Empty;

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