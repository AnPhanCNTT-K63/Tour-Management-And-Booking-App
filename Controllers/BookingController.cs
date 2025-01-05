using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using TravelWebBackEndCore.DTOs.Booking;
using TravelWebBackEndCore.Interfaces.Repository;
using TravelWebBackEndCore.Interfaces.Service;

namespace TravelWebBackEndCore.Controllers
{
    [Route("api/booking")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        private readonly IUserService _userService;
        public BookingController(IBookingService bookingService, IUserService userService)
        {
            _bookingService = bookingService;
            _userService = userService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateBooking([FromBody] CreateBookingInfoDTO createBookingInfoDTO)
        {
            var email = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;

            if (email == null)
            {

                return BadRequest("Unauthorized");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _bookingService.CreateAsync(createBookingInfoDTO, email);

            return result;
        }

        [HttpPatch("update-status/{id:int}")]
        public async Task<IActionResult> UpdateStatus([FromRoute] int id, [FromBody] UpdateBookingStatus statusDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _bookingService.UpdateStatusAsync(id, statusDTO);

            return result;
        }

        [HttpGet("user/{user_id:int}")]
        public async Task<IActionResult> GetBookingByUserId([FromRoute] int user_id, [FromQuery] string? status)
        {
            var bookings = await _bookingService.FindBookingByUserIdAsync(user_id, status);

            return bookings;
        }

        [HttpDelete("delete/{booking_id:int}")]
        public async Task<IActionResult> DeleteBooking([FromRoute] int booking_id)
        {
            var result = await _bookingService.DeleteAsync(booking_id);

            return result;
        }
    }

}
