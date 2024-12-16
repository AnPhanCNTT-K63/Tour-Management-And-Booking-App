using System.ComponentModel.DataAnnotations;

namespace TravelWebBackEndCore.DTOs.Booking
{
    public class UpdateBookingStatus
    {
        [Required]
        public int bookingId { get; set; }
        [Required]
        public string status { get; set; }
    }
}
