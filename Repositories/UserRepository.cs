using TravelWebBackEndCore.Data;
using TravelWebBackEndCore.Models;
using Microsoft.EntityFrameworkCore;
using TravelWebBackEndCore.Interfaces.Repository;

namespace TravelWebBackEndCore.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User?> FindByIdAsync(int userId)
        {
            return await _context.Users.FindAsync(userId);
        }

        public async Task<User?> FindByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
        }

        public async Task<User?> FindByNameAsync(string name)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Username == name);
        }

        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }


    }

    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly ApplicationDbContext _context;

        public UserProfileRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<UserProfile?> GetByUserIdAsync(int userId)
        {
            return await _context.UserProfiles.FirstOrDefaultAsync(x => x.UserId == userId);
        }

        public async Task AddAsync(UserProfile profile)
        {
            await _context.UserProfiles.AddAsync(profile);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
