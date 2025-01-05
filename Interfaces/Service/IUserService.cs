using Microsoft.AspNetCore.Mvc;
using TravelWebBackEndCore.DTOs.User;
using TravelWebBackEndCore.DTOs.UserProfile;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Interfaces.Service
{
    public interface IUserService
    {
        Task<User?> FindByIdAsync(int userId);
        Task<IActionResult> UpdateProfileAsync(int user_id, UpdateProfile profileDTO);
        Task<ProfileDTO?> GetProfileAsync(int user_id);
        Task<AccountDTO?> GetAccountAsync(int user_id);
        Task<IActionResult> UpdateAccountAsync(int user_id, UpdateAccountDTO accountDTO);
    }
}
