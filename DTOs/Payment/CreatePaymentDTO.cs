using System.ComponentModel.DataAnnotations;

namespace TravelWebBackEndCore.DTOs.Payment
{
    public class CreatePaymentDTO
    {
        [Required]
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        [Required]
        public string PaymentMethod { get; set; }
        [Required]
        public float PaymentAmount { get; set; }
        [Required]
        public int BookingId { get; set; }

        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;

    }
}
