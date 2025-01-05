using System.ComponentModel.DataAnnotations;

namespace TravelWebBackEndCore.DTOs.Auth
{
    public class RegisterRequestDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Role { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
