using TravelWebBackEndCore.DTOs.Auth;
using TravelWebBackEndCore.DTOs.User;

namespace TravelWebBackEndCore.Interfaces.Service
{
    public interface IAuthService
    {
        Task<(string Token, string Error)> Login(LoginRequestDTO request);
        Task<string> Register(CreateUserDTO userDTO);
    }
}
