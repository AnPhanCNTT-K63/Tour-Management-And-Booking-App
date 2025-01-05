using Microsoft.AspNetCore.Mvc;
using TravelWebBackEndCore.DTOs.Booking;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Interfaces.Service
{
    public interface IBookingService
    {
        Task<IActionResult> CreateAsync(CreateBookingInfoDTO createBookingInfoDTO, string email);
        Task<IActionResult> UpdateStatusAsync(int id, UpdateBookingStatus statusDTO);
        Task<IActionResult> FindBookingByUserIdAsync(int user_id, string? status);
        Task<IActionResult> DeleteAsync(int booking_id);
        Task<List<MyBooking>> SetMyBookingAsync(int userId, object statusFilter);
    }
}
