using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepairCostApp.Entities
{
    public class Contractor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Column("inn")]
        public string INN { get; set; } = string.Empty;

        [Column("phone")]
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