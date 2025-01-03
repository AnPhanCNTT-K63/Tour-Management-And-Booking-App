using Microsoft.AspNetCore.Mvc;
using TravelWebBackEndCore.DTOs.Auth;
using TravelWebBackEndCore.DTOs.User;

namespace TravelWebBackEndCore.Interfaces.Service
{
    public interface IAuthService
    {
        Task<IActionResult> Login(LoginRequestDTO request);
        Task<IActionResult> Register(CreateUserDTO userDTO);
        Task<IActionResult> ResetPassword(PasswordResetRequest resetPasswordDTO);
    }
}
