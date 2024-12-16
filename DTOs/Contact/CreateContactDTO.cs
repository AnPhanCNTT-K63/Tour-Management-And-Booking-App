using System.ComponentModel.DataAnnotations;
using TravelWebBackEndCore.DTOs.Booking;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.DTOs.Contact
{
    public class CreateContactDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
