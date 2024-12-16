using TravelWebBackEndCore.DTOs.User;
using TravelWebBackEndCore.DTOs.UserProfile;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Interfaces
{
    public interface IUserRepository
    {
        Task<string> UpdateProfileAsync(int user_id, UpdateProfile profileDTO);
        Task<ProfileDTO?> GetProfileAsync(int user_id);
        Task<AccountDTO?> GetAccountAsync(int user_id);
        Task<string> UpdateAccountAsync(int user_id, UpdateAccountDTO accountDTO);
    }
}
