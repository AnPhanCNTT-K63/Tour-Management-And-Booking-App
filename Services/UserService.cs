using TravelWebBackEndCore.Interfaces.Repository;
using TravelWebBackEndCore.DTOs.User;
using TravelWebBackEndCore.DTOs.UserProfile;
using TravelWebBackEndCore.Interfaces.Service;
using TravelWebBackEndCore.Models;
using TravelWebBackEndCore.Mappers;
using Microsoft.AspNetCore.Identity;

namespace TravelWebBackEndCore.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserProfileRepository _userProfileRepository;
        private readonly IPasswordHasher<User> _passwordHasher;

        public UserService(IUserRepository userRepository, IUserProfileRepository userProfileRepository, IPasswordHasher<User> passwordHasher)
        {
            _userRepository = userRepository;
            _userProfileRepository = userProfileRepository;
            _passwordHasher = passwordHasher;
        }

        public async Task<AccountDTO?> GetAccountAsync(int userId)
        {
            var user = await _userRepository.GetByIdAsync(userId);

            if (user == null)
            {
                return null;
            }

            return new AccountDTO
            {
                Email = user.Email,
                Username = user.Username
            };
        }

        public async Task<ProfileDTO?> GetProfileAsync(int userId)
        {
            var profile = await _userProfileRepository.GetByUserIdAsync(userId);

            if (profile == null)
            {
                return null;
            }

            return profile.ToProfileDTO();
        }

        public async Task<string> UpdateAccountAsync(int userId, UpdateAccountDTO accountDTO)
        {
            var user = await _userRepository.GetByIdAsync(userId);

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

            if (accountDTO.NewPassword != null)
            {
                user.Password = _passwordHasher.HashPassword(user, accountDTO.NewPassword);
            }

            user.UpdatedAt = DateTime.UtcNow;

            await _userRepository.UpdateAsync(user);
            await _userRepository.SaveChangesAsync();

            return "Account updated successfully";
        }

        public async Task<string> UpdateProfileAsync(int userId, UpdateProfile profileDTO)
        {
            var user = await _userRepository.GetByIdAsync(userId);

            if (user == null)
            {
                return "User not found";
            }

            var profile = await _userProfileRepository.GetByUserIdAsync(userId);

            if (profile == null)
            {
                profile = new UserProfile
                {
                    User = user
                };
                await _userProfileRepository.AddAsync(profile);
            }

            profile.FirstName = profileDTO.FirstName;
            profile.LastName = profileDTO.LastName;
            profile.Address = profileDTO.Address;
            profile.City = profileDTO.City;
            profile.Country = profileDTO.Country;
            profile.PostalCode = profileDTO.PostalCode;
            profile.AboutMe = profileDTO.AboutMe;
            profile.Avatar = profileDTO.Avatar;
            profile.Phone = profileDTO.Phone;
            profile.Birthday = profileDTO.Birthday;

            user.UpdatedAt = DateTime.UtcNow;

            await _userProfileRepository.SaveChangesAsync();

            return "Profile updated successfully";
        }
    }
}
