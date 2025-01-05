using System.ComponentModel.DataAnnotations;

namespace TravelWebBackEndCore.DTOs.Booking
{
    public class CreateBookingDTO
    {
        [Required]
        public DateTime BookingDate { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public int NumOfPeople { get; set; }
        [Required]
        public int TourPackageId { get; set; }
    }
}
