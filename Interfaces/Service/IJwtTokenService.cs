using TravelWebBackEndCore.DTOs.Auth;

namespace TravelWebBackEndCore.Interfaces.Service
{
    public interface IJwtTokenService
    {
        string GenerateToken(UserAuthDTO userAuth);
    }
}
