namespace TravelWebBackEndCore.DTOs.UserProfile
{
    public class UpdateProfile
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public int? PostalCode { get; set; }
        public string? AboutMe { get; set; }
        public string? Avatar { get; set; }
        public string? Phone { get; set; }
        public DateTime? Birthday { get; set; }
    }
}
