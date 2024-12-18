using Microsoft.AspNetCore.Mvc;
using TravelWebBackEndCore.Interfaces.Repository;
using TravelWebBackEndCore.Interfaces.Service;

namespace TravelWebBackEndCore.Controllers
{
    [Route("api/cloud")]
    [ApiController]
    public class CloudController : ControllerBase
    {
        private readonly ICloudService _cloudService;
        public CloudController(ICloudService cloudService)
        {
            _cloudService = cloudService;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            var result = await _cloudService.UploadFile(file);

            return result;
        }


    }
}
