namespace TravelWebBackEndCore.DTOs.Auth
{
    public class PasswordResetRequest
    {
        public string Email { get; set; }
        public string NewPassword { get; set; }
        public string VerificationCode { get; set; }
    }
}
