using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicFlow.Models.Entities
{
    public class Bill
    {
        [Key]
        public int BillId { get; set; }
        [Required]
        public int PatientId { get; set; }
        [Required]
        public string CreatedByUserId { get; set; } = null!;
        public DateTime BillDate { get; set; } = DateTime.UtcNow;
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }
        // Navigation
        [ForeignKey("PatientId")]
        public Patient Patient { get; set; } = null!;
        [ForeignKey("CreatedByUserId")]
        public ApplicationUser CreatedBy { get; set; } = null!;
        public ICollection<BillItem> BillItems { get; set; } = null!;
    }
}
