namespace TravelWebBackEndCore.DTOs.Auth
{
    public class UserAuthDTO
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        public int ExpiryInHours { get; set; }
    }
}
