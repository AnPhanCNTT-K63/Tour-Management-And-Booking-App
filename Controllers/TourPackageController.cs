using Microsoft.AspNetCore.Mvc;
using TravelWebBackEndCore.DTOs.TourPackage;
using TravelWebBackEndCore.DTOs.User;
using TravelWebBackEndCore.Interfaces.Repository;
using TravelWebBackEndCore.Interfaces.Service;

namespace TravelWebBackEndCore.Controllers
{
    [Route("api/package")]
    [ApiController]
    public class TourPackageController : ControllerBase
    {
        private readonly ITourPackageService _tourPackageService;
        public TourPackageController(ITourPackageService tourPackageService)
        {
            _tourPackageService = tourPackageService;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetPackage([FromRoute] int id)
        {
            var package = await _tourPackageService.GetById(id);
            if (package == null)
            {
                return NotFound("Package not found");
            }
            return Ok(package);
        }

        [HttpGet("tour/{tour_id:int}")]
        public async Task<IActionResult> GetPackagesByTourId([FromRoute] int tour_id)
        {
            var packages = await _tourPackageService.GetByTourId(tour_id);
            if (packages == null)
            {
                return NotFound("Packages not found");
            }
            return Ok(packages);
        }

        [HttpPut("update/{id:int}")]
        public async Task<IActionResult> UpdatePackage([FromRoute] int id, [FromBody] UpdatePackageDTO packageDTO)
        {
            var result = await _tourPackageService.UpdateAsync(id, packageDTO);

            return result;
        }

        [HttpDelete("delete/{id:int}")]
        public async Task<IActionResult> DeletePackage([FromRoute] int id)
        {
            var result = await _tourPackageService.DeleteAsync(id);

            return result;
        }
    }
}
