using TravelWebBackEndCore.DTOs.Booking;

namespace TravelWebBackEndCore.Interfaces.Service
{
    public interface IBookingService
    {
        Task<string> CreateAsync(CreateBookingInfoDTO createBookingInfoDTO);
        Task<string> UpdateStatusAsync(int id, UpdateBookingStatus statusDTO);
        Task<List<BookingDTO>> GetBookingByUserIdAsync(int user_id, string? status);
        Task<string> DeleteAsync(int booking_id);
    }
}
