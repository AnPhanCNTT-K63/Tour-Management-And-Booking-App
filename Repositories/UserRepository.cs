using Azure.Core;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TravelWebBackEndCore.Data;
using TravelWebBackEndCore.DTOs.User;
using TravelWebBackEndCore.DTOs.UserProfile;
using TravelWebBackEndCore.Interfaces;
using TravelWebBackEndCore.Mappers;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IPasswordHasher<User> _passwordHasher;
        public UserRepository(ApplicationDbContext context, IPasswordHasher<User> passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;
        }

        public async Task<AccountDTO?> GetAccountAsync(int user_id)
        {
            var user = await _context.Users.FindAsync(user_id);

            if (user == null)
            {
                return null;
            }

            var account = new AccountDTO
            {
                Email = user.Email,
                Username = user.Username,
            };

            return account;
        }

        public async Task<ProfileDTO?> GetProfileAsync(int user_id)
        {
            var profile = await _context.UserProfiles.FirstOrDefaultAsync(x => x.UserId == user_id);

            if (profile == null)
            {
                return null;
            }
            return profile.ToProfileDTO();
        }

        public async Task<string> UpdateAccountAsync(int user_id, UpdateAccountDTO accountDTO)
        {
            try
            {
                var user = await _context.Users.FindAsync(user_id);

                if (user == null)
                {
                    return "User not found";
                }

                if (accountDTO.Password == null)
                {
                    return "Password is required";
                }

                var passwordVerificationResult = _passwordHasher.VerifyHashedPassword(user, user.Password, accountDTO.Password);

                if (passwordVerificationResult == PasswordVerificationResult.Failed)
                {
                    return "Invalid password";
                }

                if (accountDTO.Email != null)
                {
                    user.Email = accountDTO.Email;
                }

                if (accountDTO.Username != null)
                {
                    user.Username = accountDTO.Username;
                }

                if(accountDTO.NewPassword != null)
                {
                    user.Password = _passwordHasher.HashPassword(user, accountDTO.NewPassword);
                }

                user.UpdatedAt = DateTime.UtcNow;

                await _context.SaveChangesAsync();

                return "Account updated successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> UpdateProfileAsync(int user_id, UpdateProfile profileDTO)
        {
            try
            {
                var existingUser = await _context.Users.FindAsync(user_id);

                if (existingUser == null)
                {
                    return "User not found";
                }

                var existingProfile = await _context.UserProfiles.FirstOrDefaultAsync(x => x.UserId == user_id);

                if (existingProfile == null)
                {
                    existingProfile = new UserProfile
                    {
                        User = existingUser
                    };
                    _context.UserProfiles.Add(existingProfile);
                }

                existingProfile.FirstName = profileDTO.FirstName;
                existingProfile.LastName = profileDTO.LastName;
                existingProfile.Address = profileDTO.Address;
                existingProfile.City = profileDTO.City;
                existingProfile.Country = profileDTO.Country;
                existingProfile.PostalCode = profileDTO.PostalCode;
                existingProfile.AboutMe = profileDTO.AboutMe;
                existingProfile.Avatar = profileDTO.Avatar;
                existingProfile.Phone = profileDTO.Phone;
                existingProfile.Birthday = profileDTO.Birthday;

                existingUser.UpdatedAt = DateTime.UtcNow;

                await _context.SaveChangesAsync();

                return "Profile updated successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
