using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Interfaces.Repository
{
    public interface IUserRepository
    {
        Task<User?> GetByIdAsync(int userId);
        Task UpdateAsync(User user);
        Task SaveChangesAsync();
    }

    public interface IUserProfileRepository
    {
        Task<UserProfile?> GetByUserIdAsync(int userId);
        Task AddAsync(UserProfile profile);
        Task SaveChangesAsync();
    }
}
