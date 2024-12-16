using Microsoft.AspNetCore.Mvc;
using TravelWebBackEndCore.DTOs.User;
using TravelWebBackEndCore.DTOs.UserProfile;
using TravelWebBackEndCore.Interfaces;

namespace TravelWebBackEndCore.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPut("{user_id:int}/update-profile")]
        public async Task<IActionResult> UpdateProfile([FromRoute] int user_id, [FromBody] UpdateProfile profileDTO)
        {
            var result = await _userRepository.UpdateProfileAsync(user_id, profileDTO);

            if (result == "User not found")
            {
                return NotFound(result);
            }

            if (result != "Profile updated successfully")
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpGet("{user_id:int}/profile")]
        public async Task<IActionResult> GetProfileById([FromRoute] int user_id)
        {
            var profile = await _userRepository.GetProfileAsync(user_id);
            if (profile == null)
            {
                return NotFound("Not found");
            }
            return Ok(profile);
        }

        [HttpGet("{user_id:int}/account")]
        public async Task<IActionResult> GetAccountById([FromRoute] int user_id)
        {
            var account = await _userRepository.GetAccountAsync(user_id);
            if (account == null)
            {
                return NotFound("Not found");
            }
            return Ok(account);
        }

        [HttpPut("{user_id:int}/update-account")]
        public async Task<IActionResult> UpdateAccount([FromRoute] int user_id, [FromBody] UpdateAccountDTO accountDTO)
        {
            var result = await _userRepository.UpdateAccountAsync(user_id, accountDTO);
            if (result == "User not found")
            {
                return NotFound(result);
            }
            if (result != "Account updated successfully")
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

    }
}
