using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepairCostApp.Entities
{
    public class CostArticle
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Column("unit")]
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