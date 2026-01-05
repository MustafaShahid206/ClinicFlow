using System.ComponentModel.DataAnnotations;

namespace ClinicFlow.Models.Entities
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; } = null!;
        [Required]
        [MaxLength(20)]
        public string Phone { get; set; } = null!;
        [Required]
        [MaxLength(10)]
        public string Gender { get; set; } = null!;
        public DateTime? DateOfBirth { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        // Navigation
        public ICollection<Visit> Visits { get; set; } = null!;
        public ICollection<Bill> Bills { get; set; } = null!;
    }
}
