using Microsoft.AspNetCore.Mvc;
using TravelWebBackEndCore.DTOs.Auth;

namespace TravelWebBackEndCore.Interfaces.Service
{
    public interface IGoogleService
    {
        Task<IActionResult> GoogleLogin(GoogleLoginDTO model);
    }
}
