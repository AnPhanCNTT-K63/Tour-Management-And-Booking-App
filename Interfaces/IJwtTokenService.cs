using TravelWebBackEndCore.DTOs.Auth;

namespace TravelWebBackEndCore.Interfaces
{
    public interface IJwtTokenService
    {
      string GenerateToken(UserAuthDTO userAuth);
    }
}
