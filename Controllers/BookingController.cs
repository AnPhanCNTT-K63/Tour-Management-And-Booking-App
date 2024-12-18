using Microsoft.AspNetCore.Mvc;
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
        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateBooking([FromBody] CreateBookingInfoDTO createBookingInfoDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _bookingService.CreateAsync(createBookingInfoDTO);

            if (result == "User not found")
            {
                return NotFound(result);
            }

            if (result != "Booking created successfully")
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpPatch("update-status")]
        public async Task<IActionResult> UpdateStatus([FromRoute] int id, [FromBody] UpdateBookingStatus statusDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _bookingService.UpdateStatusAsync(id, statusDTO);
            if (result == "Booking not found")
            {
                return NotFound(result);
            }
            if (result != "Booking status updated successfully")
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpGet("user/{user_id:int}")]
        public async Task<IActionResult> GetBookingByUserId([FromRoute] int user_id, [FromQuery] string? status)
        {
            var bookings = await _bookingService.GetBookingByUserIdAsync(user_id, status);

            return Ok(bookings);
        }

        [HttpDelete("delete/{booking_id:int}")]
        public async Task<IActionResult> DeleteBooking([FromRoute] int booking_id)
        {
            var result = await _bookingService.DeleteAsync(booking_id);
            if (result == "Booking not found")
            {
                return NotFound(result);
            }
            if (result != "Booking deleted successfully")
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }

}
