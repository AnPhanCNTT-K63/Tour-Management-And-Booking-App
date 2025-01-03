using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using TravelWebBackEndCore.Data;
using TravelWebBackEndCore.DTOs.Booking;
using TravelWebBackEndCore.Interfaces.Repository;
using TravelWebBackEndCore.Interfaces.Service;
using TravelWebBackEndCore.Mappers;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IUserRepository _userRepository;
        private readonly IContactRepository _contactRepository;
        private readonly ITravelerRepository _travelerRepository;
        private readonly ITourPackageRepository _tourPackageRepository;
        public BookingService(ApplicationDbContext context,
            IBookingRepository bookingRepository,
            IUserRepository userRepository,
            ITourPackageRepository tourPackageRepository,
            IContactRepository contactRepository,
            ITravelerRepository travelerRepository
            )
        {
            _bookingRepository = bookingRepository;
            _userRepository = userRepository;
            _tourPackageRepository = tourPackageRepository;
            _contactRepository = contactRepository;
            _travelerRepository = travelerRepository;

        }
        public async Task<IActionResult> CreateAsync(CreateBookingInfoDTO bookingDTO, string email)
        {
            try
            {
                var booking = bookingDTO.Booking.ToBooking();
                var user = await _userRepository.FindByEmailAsync(email);
                var package = await _tourPackageRepository.FindByIdAsync(bookingDTO.Booking.TourPackageId);

                if (user == null)
                {
                    return new NotFoundObjectResult("User not found");
                }

                booking.User = user;

                if (package == null)
                {
                    return new NotFoundObjectResult("Tour package not found");
                }

                booking.TourPackage = package;

                await _bookingRepository.AddAsync(booking);

                var contact = bookingDTO.Contact.ToContact();
                contact.Booking = booking;
                await _contactRepository.AddAsync(contact);

                if (bookingDTO.Travelers != null)
                {
                    var travelers = bookingDTO.Travelers.Select(travelerDTO =>
                    {
                        var traveler = travelerDTO.ToTraveler();
                        traveler.Booking = booking;
                        return traveler;
                    });

                    await _travelerRepository.AddRangeAsync(travelers);
                }

                await _bookingRepository.SaveChangesAsync();


                return new OkObjectResult(booking.Id);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }

        public async Task<IActionResult> DeleteAsync(int booking_id)
        {
            try
            {
                var booking = await _bookingRepository.FindByIdAsync(booking_id);

                if (booking == null)
                {
                    return new NotFoundObjectResult("Booking not found");
                }

                booking.IsDeleted = true;
                await _bookingRepository.SaveChangesAsync();

                return new OkObjectResult("Booking deleted successfully");

            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }

        public async Task<IActionResult> FindBookingByUserIdAsync(int userId, string? status)
        {
            var user = _userRepository.FindByIdAsync(userId);

            if (user == null)
            {
                return new NotFoundObjectResult("User not found");
            }

            var bookingsQuery = await _bookingRepository.FindBookingsByUserIdAsync(userId);

            if (bookingsQuery == null)
            {
                return new NotFoundObjectResult("No bookings found for the user");
            }

            if (!string.IsNullOrEmpty(status))
            {
                bookingsQuery = bookingsQuery.Where(b => b.Status == status);
            }

            var bookingDTOs = await bookingsQuery.Select(b => b.ToBookingDTO()).ToListAsync();
            return new OkObjectResult(bookingDTOs);
        }


        public async Task<IActionResult> UpdateStatusAsync(int id, UpdateBookingStatus statusDTO)
        {
            try
            {
                if (statusDTO.status == null)
                {
                    return new BadRequestObjectResult("Status cannot be null or empty.");
                }

                var booking = await _bookingRepository.FindByIdAsync(id);

                if (booking == null)
                {
                    return new NotFoundObjectResult("Booking not found");
                }

                booking.Status = statusDTO.status;
                await _bookingRepository.SaveChangesAsync();
                return new OkObjectResult("Booking status updated successfully");
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);

            }
        }
    }
}
