using System.ComponentModel.DataAnnotations;

namespace TravelWebBackEndCore.DTOs.Booking
{
    public class UpdateBookingStatus
    {

        [Required]
        public string status { get; set; }
    }
}
