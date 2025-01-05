using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Interfaces.Repository
{
    public interface IUserRepository
    {
        Task<User?> FindByIdAsync(int userId);
        Task<User?> FindByEmailAsync(string email);
        Task<User?> FindByNameAsync(string name);
        Task AddAsync(User user);
        Task SaveChangesAsync();
    }

    public interface IUserProfileRepository
    {
        Task<UserProfile?> GetByUserIdAsync(int userId);
        Task AddAsync(UserProfile profile);
        Task SaveChangesAsync();
    }
}
