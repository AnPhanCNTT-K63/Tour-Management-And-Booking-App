using Microsoft.AspNetCore.Mvc;
using TravelWebBackEndCore.DTOs.Tour;
using TravelWebBackEndCore.Helpers;
using TravelWebBackEndCore.Interfaces.Repository;
using TravelWebBackEndCore.Interfaces.Service;

namespace TravelWebBackEndCore.Controllers
{
    [Route("api/tour")]
    [ApiController]
    public class TourController : ControllerBase
    {
        private readonly ITourService _tourService;
        public TourController(ITourService tourService)
        {
            _tourService = tourService;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll([FromQuery] QueryTour query)
        {
            var tours = await _tourService.GetAllAsync(query);
            return Ok(tours);
        }

        [HttpPost("create-tour-and-package")]
        public async Task<IActionResult> Create([FromBody] CreateTourWithPackageDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _tourService.CreateTourWithPackageAsync(dto);

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
            var tour = await _tourService.GetTourByIdAsync(id);
            if (tour == null)
            {
                return NotFound("Not found");
            }
            return Ok(tour);
        }

        [HttpDelete("soft-delete/{id:int}")]
        public async Task<IActionResult> SoftDelete([FromRoute] int id)
        {
            var result = await _tourService.SoftDeleteAsync(id);
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
            var result = await _tourService.RestoreAsynce(id);
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
            var result = await _tourService.DeltedAsync(id);
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
