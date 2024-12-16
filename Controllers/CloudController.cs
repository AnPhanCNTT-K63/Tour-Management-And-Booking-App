using Microsoft.AspNetCore.Mvc;
using TravelWebBackEndCore.Interfaces;

namespace TravelWebBackEndCore.Controllers
{
    [Route("api/cloud")]
    [ApiController]
    public class CloudController : ControllerBase
    {
        private readonly ICloudRepository _cloudRepository;
        public CloudController(ICloudRepository cloudRepository)
        {
            _cloudRepository = cloudRepository;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            var result = await _cloudRepository.UploadFile(file);

            if (result == "File is missing or empty.")
            {
                return BadRequest(result);
            }

            if (result != "File uploaded successfully.")
            {
                return StatusCode(500, result);
            }

            return Ok(result);
        }


    }
}
