using TravelWebBackEndCore.DTOs.User;
using TravelWebBackEndCore.DTOs.UserProfile;

namespace TravelWebBackEndCore.Interfaces.Service
{
    public interface IUserService
    {
        Task<string> UpdateProfileAsync(int user_id, UpdateProfile profileDTO);
        Task<ProfileDTO?> GetProfileAsync(int user_id);
        Task<AccountDTO?> GetAccountAsync(int user_id);
        Task<string> UpdateAccountAsync(int user_id, UpdateAccountDTO accountDTO);
    }
}
