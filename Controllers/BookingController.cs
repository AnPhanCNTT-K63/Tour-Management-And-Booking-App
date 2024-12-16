using Microsoft.AspNetCore.Mvc;
using TravelWebBackEndCore.DTOs.Booking;
using TravelWebBackEndCore.Interfaces;

namespace TravelWebBackEndCore.Controllers
{
    [Route("api/booking")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingRepository _bookingRepository;
        public BookingController(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateBooking([FromBody] CreateBookingInfoDTO createBookingInfoDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _bookingRepository.CreateAsync(createBookingInfoDTO);

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
        public async Task<IActionResult> UpdateStatus([FromBody] UpdateBookingStatus statusDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _bookingRepository.UpdateStatusAsync(statusDTO);
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

        [HttpGet("get-by-user-id/{user_id:int}")]
        public async Task<IActionResult> GetBookingByUserId([FromRoute] int user_id, [FromQuery] string? status)
        {
            var bookings = await _bookingRepository.GetBookingByUserIdAsync(user_id, status);

            return Ok(bookings);
        }

        [HttpDelete("delete/{booking_id:int}")]
        public async Task<IActionResult> DeleteBooking([FromRoute] int booking_id)
        {
            var result = await _bookingRepository.DeleteAsync(booking_id);
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
