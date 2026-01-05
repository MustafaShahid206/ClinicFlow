using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicFlow.Models.Entities
{
    public class BillItem
    {
        [Key]
        public int BillItemId { get; set; }
        [Required]
        public int BillId { get; set; }
        [Required]
        public int ServiceId { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        // Navigation
        [ForeignKey("BillId")]
        public Bill Bill { get; set; } = null!;
        [ForeignKey("ServiceId")]
        public Service Service { get; set; } = null!;
    }
}
