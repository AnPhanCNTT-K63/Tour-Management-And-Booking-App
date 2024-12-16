using TravelWebBackEndCore.DTOs.Booking;

namespace TravelWebBackEndCore.Interfaces
{
    public interface IBookingRepository
    {
        Task<string> CreateAsync(CreateBookingInfoDTO createBookingInfoDTO);
        Task<string> UpdateStatusAsync(UpdateBookingStatus statusDTO);
        Task<List<BookingDTO>> GetBookingByUserIdAsync(int user_id, string? status);
        Task<string> DeleteAsync(int booking_id);
    }
}
