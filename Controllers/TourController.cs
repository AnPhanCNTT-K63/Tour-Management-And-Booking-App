using Microsoft.AspNetCore.Mvc;
using TravelWebBackEndCore.DTOs.Tour;
using TravelWebBackEndCore.DTOs.TourPackage;
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
            else if (result == "Create failure")
            {
                return BadRequest(result);
            }
            else if (result == "Create success")
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("get-by-id/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var tour = await _tourRepository.GetTourByIdAsync(id);
            if (tour == null)
            {
                return NotFound("Not found");
            }
            return Ok(tour);
        }
    }
}
