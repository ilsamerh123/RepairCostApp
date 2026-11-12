using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepairCostApp.Entities
{
    public class EstimateItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("estimateid")]
        public int EstimateId { get; set; }

        [Required]
        [Column("repairworkid")]
        public int RepairWorkId { get; set; }

        [NotMapped]
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