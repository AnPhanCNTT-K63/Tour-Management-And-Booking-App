namespace TravelWebBackEndCore.DTOs.User
{
    public class UpdateAccountDTO
    {
        public string? Email { get; set; }
        public string? Username { get; set; }
        public string? NewPassword { get; set; }
        public string? Password { get; set; }
        
    }
}
