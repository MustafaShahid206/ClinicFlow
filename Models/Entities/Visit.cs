using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicFlow.Models.Entities
{
    public class Visit
    {
        [Key]
        public int VisitId { get; set; }
        [Required]
        public int PatientId { get; set; }
        [Required]
        public string DoctorId { get; set; } = null!;
        public DateTime VisitDate { get; set; } = DateTime.UtcNow;
        [MaxLength(500)]
        public string Notes { get; set; } = null!;
        // Navigation
        [ForeignKey("PatientId")]
        public Patient Patient { get; set; } = null!;

        [ForeignKey("DoctorId")]
        public ApplicationUser Doctor { get; set; } = null!;
    }
}
