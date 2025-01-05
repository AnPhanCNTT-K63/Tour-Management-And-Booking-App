using Microsoft.AspNetCore.Mvc;
using TravelWebBackEndCore.DTOs.User;
using TravelWebBackEndCore.DTOs.UserProfile;
using TravelWebBackEndCore.Interfaces.Repository;
using TravelWebBackEndCore.Interfaces.Service;

namespace TravelWebBackEndCore.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPut("update-profile/{user_id:int}")]
        public async Task<IActionResult> UpdateProfile([FromRoute] int user_id, [FromBody] UpdateProfile profileDTO)
        {
            var result = await _userService.UpdateProfileAsync(user_id, profileDTO);

            return result;
        }

        [HttpGet("{user_id:int}/profile")]
        public async Task<IActionResult> GetProfileById([FromRoute] int user_id)
        {
            var profile = await _userService.GetProfileAsync(user_id);

            if (profile == null)
            {
                return NotFound("Not found");
            }

            return Ok(profile);
        }

        [HttpGet("{user_id:int}/account")]
        public async Task<IActionResult> GetAccountById([FromRoute] int user_id)
        {
            var account = await _userService.GetAccountAsync(user_id);

            if (account == null)
            {
                return NotFound("Not found");
            }

            return Ok(account);
        }

        [HttpPut("update-account/{user_id:int}")]
        public async Task<IActionResult> UpdateAccount([FromRoute] int user_id, [FromBody] UpdateAccountDTO accountDTO)
        {
            var result = await _userService.UpdateAccountAsync(user_id, accountDTO);

            return result;
        }

    }
}
