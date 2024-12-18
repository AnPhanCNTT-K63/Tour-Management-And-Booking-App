using Microsoft.EntityFrameworkCore;
using TravelWebBackEndCore.Data;
using TravelWebBackEndCore.DTOs.Booking;
using TravelWebBackEndCore.Interfaces.Repository;
using TravelWebBackEndCore.Interfaces.Service;
using TravelWebBackEndCore.Mappers;

namespace TravelWebBackEndCore.Services
{
    public class BookingService : IBookingService
    {
        private readonly ApplicationDbContext _context;
        public BookingService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<string> CreateAsync(CreateBookingInfoDTO bookingDTO)
        {
            try
            {
                var booking = bookingDTO.Booking.ToBooking();
                var user = await _context.Users.FindAsync(bookingDTO.Booking.UserId);
                var package = await _context.TourPackages.FindAsync(bookingDTO.Booking.TourPackageId);

                if (user == null)
                {
                    return "User not found";
                }

                booking.User = user;

                if (package == null)
                {
                    return "Tour package not found";
                }

                booking.TourPackage = package;

                await _context.Bookings.AddAsync(booking);




                var contact = bookingDTO.Contact.ToContact();
                contact.Booking = booking;
                await _context.Contacts.AddAsync(contact);

                if (bookingDTO.Travelers != null)
                {
                    var travelers = bookingDTO.Travelers.Select(travelerDTO =>
                    {
                        var traveler = travelerDTO.ToTraveler();
                        traveler.Booking = booking;
                        return traveler;
                    });

                    await _context.Travelers.AddRangeAsync(travelers);
                }

                await _context.SaveChangesAsync();
                return "Booking created successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> DeleteAsync(int booking_id)
        {
            try
            {
                var booking = await _context.Bookings.FindAsync(booking_id);

                if (booking == null)
                {
                    return "Booking not found";
                }

                booking.IsDeleted = true;
                await _context.SaveChangesAsync();

                return "Booking deleted successfully";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<List<BookingDTO>> GetBookingByUserIdAsync(int user_id, string? status)
        {
            var bookings = _context.Bookings.Where(b => b.UserId == user_id && b.IsDeleted == false);

            if (status != null)
            {
                bookings = bookings.Where(b => b.Status == status);
            }

            return await bookings.Select(b => b.ToBookingDTO()).ToListAsync();

        }

        public async Task<string> UpdateStatusAsync(int id, UpdateBookingStatus statusDTO)
        {
            try
            {
                if (statusDTO.status == null)
                {
                    return "Status cannot be null or empty.";
                }

                var booking = await _context.Bookings.FindAsync(id);

                if (booking == null)
                {
                    return "Booking not found";
                }

                booking.Status = statusDTO.status;
                await _context.SaveChangesAsync();
                return "Booking status updated successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
    }
}
