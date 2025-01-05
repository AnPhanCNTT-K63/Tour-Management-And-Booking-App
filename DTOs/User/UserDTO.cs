using System.ComponentModel.DataAnnotations;
using TravelWebBackEndCore.DTOs.UserProfile;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.DTOs.User
{
    public class UserDTO
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string Role { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public string VerificationCode { get; set; }
        public DateTime VerificationCodeExpiration { get; set; }
        public ProfileDTO UserProfile { get; set; }
    }
}
