using System.ComponentModel.DataAnnotations;
using TravelWebBackEndCore.DTOs.Contact;
using TravelWebBackEndCore.DTOs.Traveler;

namespace TravelWebBackEndCore.DTOs.Booking
{
    public class CreateBookingInfoDTO
    {
        [Required]
        public CreateBookingDTO Booking { get; set; }
        [Required]
        public CreateContactDTO Contact { get; set; }
        public List<CreateTravelerDTO>? Travelers { get; set; }
    }
}
