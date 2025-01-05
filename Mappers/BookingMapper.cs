using TravelWebBackEndCore.DTOs.Booking;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Mappers
{
    public static class BookingMapper
    {

        public static BookingDTO ToBookingDTO(this Booking booking)
        {
            return new BookingDTO
            {
                Id = booking.Id,
                BookingDate = booking.BookingDate,
                Status = booking.Status,
                NumOfPeople = booking.NumOfPeople,
                TourPackageId = booking.TourPackageId,
                UserId = booking.UserId,
                CreatedAt = booking.CreatedAt,

            };
        }
        public static Booking ToBooking(this CreateBookingDTO createBookingDTO)
        {
            return new Booking
            {
                BookingDate = createBookingDTO.BookingDate,
                Status = createBookingDTO.Status,
                NumOfPeople = createBookingDTO.NumOfPeople,
                TourPackageId = createBookingDTO.TourPackageId,
            };
        }
    }
}
