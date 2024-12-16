using Microsoft.AspNetCore.Mvc;
using TravelWebBackEndCore.DTOs.TourPackage;
using TravelWebBackEndCore.DTOs.User;
using TravelWebBackEndCore.Interfaces;

namespace TravelWebBackEndCore.Controllers
{
    [Route("api/package")]
    [ApiController]
    public class TourPackageController : ControllerBase
    {
        private readonly ITourPackageRepository _tourPackageRepository;
        public TourPackageController(ITourPackageRepository tourPackageRepository)
        {
            _tourPackageRepository = tourPackageRepository;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetPackage([FromRoute] int id)
        {
            var package = await _tourPackageRepository.GetById(id);
            if (package == null)
            {
                return NotFound("Package not found");
            }
            return Ok(package);
        }

        [HttpGet("tour/{tour_id:int}")]
        public async Task<IActionResult> GetPackagesByTourId([FromRoute] int tour_id)
        {
            var packages = await _tourPackageRepository.GetByTourId(tour_id);
            if (packages == null)
            {
                return NotFound("Packages not found");
            }
            return Ok(packages);
        }

        [HttpPut("update/{id:int}")]
        public async Task<IActionResult> UpdatePackage([FromRoute] int id, [FromBody] UpdatePackageDTO packageDTO)
        {
            var result = await _tourPackageRepository.UpdateAsync(id, packageDTO);

            if (result == "Package not found")
            {
                return NotFound(result);
            }

            if (result == "Package updated successfully")
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpDelete("delete/{id:int}")]
        public async Task<IActionResult> DeletePackage([FromRoute] int id)
        {
            var result = await _tourPackageRepository.DeleteAsync(id);
            if (result == "Package not found")
            {
                return NotFound(result);
            }
            if (result == "Package deleted successfully")
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
