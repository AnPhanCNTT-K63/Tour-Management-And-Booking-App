using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelWebBackEndCore.Data;
using TravelWebBackEndCore.DTOs.Auth;
using TravelWebBackEndCore.DTOs.User;
using TravelWebBackEndCore.Interfaces.Repository;
using TravelWebBackEndCore.Interfaces.Service;
using TravelWebBackEndCore.Mappers;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserProfileRepository _userProfileRepository;
        private readonly IJwtTokenService _tokenService;
        private readonly IPasswordHasher<User> _passwordHasher;

        public AuthService(
            ApplicationDbContext context,
            IUserRepository userRepository,
            IUserProfileRepository userProfileRepository,
            IJwtTokenService tokenService,
            IPasswordHasher<User> passwordHasher
            )
        {
            _userRepository = userRepository;
            _userProfileRepository = userProfileRepository;
            _tokenService = tokenService;
            _passwordHasher = passwordHasher;
        }

        public async Task<IActionResult> Login(LoginRequestDTO request)
        {
            var user = await _userRepository.FindByEmailAsync(request.Email);

            if (user == null)
            {
                return new BadRequestObjectResult("Invalid email or password");
            }

            var passwordVerificationResult = _passwordHasher.VerifyHashedPassword(user, user.Password, request.Password);

            if (passwordVerificationResult == PasswordVerificationResult.Failed)
            {
                return new BadRequestObjectResult("Invalid email or password");
            }

            var userAuth = new UserAuthDTO
            {
                Email = user.Email,
                Username = user.Username,
                Role = user.Role,
                ExpiryInHours = 72
            };

            var token = _tokenService.GenerateToken(userAuth);

            return new OkObjectResult(token);
        }

        public async Task<IActionResult> Register(CreateUserDTO userDTO)
        {
            var existingUserEmail = await _userRepository.FindByEmailAsync(userDTO.Email);
            var existingUserName = await _userRepository.FindByNameAsync(userDTO.Username);

            if (existingUserEmail != null)
            {
                return new BadRequestObjectResult("Email already exists");
            }

            if (existingUserName != null)
            {
                return new BadRequestObjectResult("Username already exists");
            }

            var newUser = userDTO.ToUser();

            newUser.Password = _passwordHasher.HashPassword(newUser, userDTO.Password);

            await _userRepository.AddAsync(newUser);

            var newProfile = new UserProfile
            {
                User = newUser
            };
            await _userProfileRepository.AddAsync(newProfile);

            await _userRepository.SaveChangesAsync();

            return new OkObjectResult("User registered successfully");
        }
    }
}
