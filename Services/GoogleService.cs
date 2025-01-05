using Google.Apis.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using TravelWebBackEndCore.DTOs.Auth;
using TravelWebBackEndCore.Interfaces.Repository;
using TravelWebBackEndCore.Interfaces.Service;
using TravelWebBackEndCore.Models;
using TravelWebBackEndCore.Repositories;

namespace TravelWebBackEndCore.Services
{
    public class GoogleService : IGoogleService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserProfileRepository _userProfileRepository;
        private readonly IJwtTokenService _tokenService;

        public GoogleService(
            IUserRepository userRepository,
            IUserProfileRepository userProfileRepository,
            IJwtTokenService tokenService
            )
        {
            _userRepository = userRepository;
            _userProfileRepository = userProfileRepository;
            _tokenService = tokenService;
        }
        public async Task<IActionResult> GoogleLogin(GoogleLoginDTO model)
        {
            if (model == null || string.IsNullOrEmpty(model.IdToken))
            {
                throw new BadHttpRequestException("Invalid Google token");
            }

            try
            {
                var payload = GoogleJsonWebSignature.ValidateAsync(model.IdToken).Result;

                if (payload == null)
                {
                    throw new UnauthorizedAccessException("Invalid Google token");
                }

                var user = await _userRepository.FindByEmailAsync(payload.Email);
                if (user == null)
                {
                    user = new User
                    {
                        Username = payload.Name,
                        Email = payload.Email,
                        Role = "user",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,

                    };

                    await _userRepository.AddAsync(user);
                    await _userRepository.SaveChangesAsync();


                    var profile = new UserProfile
                    {
                        UserId = user.Id
                    };

                    await _userProfileRepository.AddAsync(profile);
                    await _userProfileRepository.SaveChangesAsync();
                }

                var userAuth = new UserAuthDTO
                {
                    Email = user.Email,
                    Username = user.Username,
                    Role = "user",
                    ExpiryInHours = 72
                };


                var token = _tokenService.GenerateToken(userAuth);

                return new OkObjectResult(new
                {
                    message = "Success",
                    token = token,
                });
            }
            catch (Exception ex)
            {
                throw new BadHttpRequestException(ex.Message);
            }
        }
    }
}
