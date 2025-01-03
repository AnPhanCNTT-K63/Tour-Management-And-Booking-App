using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
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

        [HttpGet("get/{page:int}/{pageSize:int}")]
        public async Task<IActionResult> GetAll([FromRoute] int page, [FromRoute] int pageSize, [FromQuery] QueryTour query)
        {
            var paginatedTours = await _tourService.GetAllAsync(page, pageSize, query);

            return Ok(new
            {
                Tours = paginatedTours.Tours,
                TotalCount = paginatedTours.TotalCount
            });
        }

        [HttpPost("create-tour-and-package")]
        public async Task<IActionResult> Create([FromBody] CreateTourWithPackageDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _tourService.CreateTourWithPackageAsync(dto);


            return result;

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

            return result;

        }

        [HttpPatch("restore/{id:int}")]
        public async Task<IActionResult> Restore([FromRoute] int id)
        {
            var result = await _tourService.RestoreAsync(id);

            return result;
        }

        [HttpDelete("delete/{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var result = await _tourService.DeltedAsync(id);

            return result;
        }
    }
}
