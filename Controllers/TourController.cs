using Microsoft.AspNetCore.Mvc;
using TravelWebBackEndCore.DTOs.Tour;
using TravelWebBackEndCore.Helpers;
using TravelWebBackEndCore.Interfaces;

namespace TravelWebBackEndCore.Controllers
{
    [Route("api/tour")]
    [ApiController]
    public class TourController : ControllerBase
    {
        private readonly ITourRepository _tourRepository;
        public TourController(ITourRepository tourRepository)
        {
            _tourRepository = tourRepository;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll([FromQuery] QueryTour query)
        {
            var tours = await _tourRepository.GetAllAsync(query);
            return Ok(tours);
        }

        [HttpPost("create-tour-and-package")]
        public async Task<IActionResult> Create([FromBody] CreateTourWithPackageDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _tourRepository.CreateTourWithPackageAsync(dto);

            if (result == "User not found")
            {
                return NotFound(result);
            }

            if (result == "Create success")
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var tour = await _tourRepository.GetTourByIdAsync(id);
            if (tour == null)
            {
                return NotFound("Not found");
            }
            return Ok(tour);
        }

        [HttpDelete("soft-delete/{id:int}")]
        public async Task<IActionResult> SoftDelete([FromRoute] int id)
        {
            var result = await _tourRepository.SoftDeleteAsync(id);
            if (result == "Not found")
            {
                return NotFound(result);
            }

            if (result == "Delete success")
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpPatch("restore/{id:int}")]
        public async Task<IActionResult> Restore([FromRoute] int id)
        {
            var result = await _tourRepository.RestoreAsynce(id);
            if (result == "Not found")
            {
                return NotFound(result);
            }
            if (result == "Restore success")
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete/{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var result = await _tourRepository.DeltedAsync(id);
            if (result == "Not found")
            {
                return NotFound(result);
            }
            if (result == "Delete success")
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
