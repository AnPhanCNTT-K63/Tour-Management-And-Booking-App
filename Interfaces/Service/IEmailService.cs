using Microsoft.AspNetCore.Mvc;
using TravelWebBackEndCore.DTOs.Auth;

namespace TravelWebBackEndCore.Interfaces.Service
{
    public interface IEmailService
    {
        Task<IActionResult> SendPasswordResetCode(EmailRequestDTO emailRequest);
    }
}
