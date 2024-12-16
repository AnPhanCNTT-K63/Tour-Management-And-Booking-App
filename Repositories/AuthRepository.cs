using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TravelWebBackEndCore.Data;
using TravelWebBackEndCore.DTOs.Auth;
using TravelWebBackEndCore.DTOs.User;
using TravelWebBackEndCore.Interfaces;
using TravelWebBackEndCore.Mappers;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IJwtTokenService _tokenService;
        private readonly IPasswordHasher<User> _passwordHasher;

        public AuthRepository(
            ApplicationDbContext context,
            IJwtTokenService tokenService,
            IPasswordHasher<User> passwordHasher)
        {
            _context = context;
            _tokenService = tokenService;
            _passwordHasher = passwordHasher;
        }

        public async Task<(string Token, string Error)> Login(LoginRequestDTO request)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == request.Email);

            if (user == null)
            {
                return (string.Empty, "Invalid email or password");
            }

            var passwordVerificationResult = _passwordHasher.VerifyHashedPassword(user, user.Password, request.Password);

            if (passwordVerificationResult == PasswordVerificationResult.Failed)
            {
                return (string.Empty, "Invalid email or password");
            }

            var userAuth = new UserAuthDTO
            {
                Email = user.Email,
                Username = user.Username,
                Role = user.Role,
                ExpiryInHours = 72
            };

            var token = _tokenService.GenerateToken(userAuth);

            return (token, string.Empty);
        }

        public async Task<string> Register(CreateUserDTO userDTO)
        {
            var existingUser = await _context.Users.FirstOrDefaultAsync(u =>
                u.Email == userDTO.Email || u.Username == userDTO.Username);

            if (existingUser != null)
            {
                if (existingUser.Email == userDTO.Email)
                    return "Email already exists";
                if (existingUser.Username == userDTO.Username)
                    return "Username already exists";
            }

            var newUser = userDTO.ToUser();

            newUser.Password = _passwordHasher.HashPassword(newUser, userDTO.Password);

            await _context.Users.AddAsync(newUser);

            var newProfile = new UserProfile
            {
                User = newUser
            };
            await _context.UserProfiles.AddAsync(newProfile);

            await _context.SaveChangesAsync();

            return "User registered successfully";
        }
    }
}
