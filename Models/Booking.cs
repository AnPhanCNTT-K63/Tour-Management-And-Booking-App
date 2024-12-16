using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TravelWebBackEndCore.Models
{
    [Table("Booking")]
    public class Booking
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime BookingDate { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public int NumOfPeople { get; set; }
        public bool IsDeleted { get; set; } = false;
        [Required]
        public int TourPackageId { get; set; }
        [Required]
        public int UserId { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public User User { get; set; }
        public TourPackage TourPackage { get; set; }
        public Contact? Contact { get; set; }
        public Payment? Payment { get; set; }
        public ICollection<Traveler>? Travelers { get; set; }
    }
}
