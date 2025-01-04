using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelWebBackEndCore.Data;
using TravelWebBackEndCore.DTOs.Booking;
using TravelWebBackEndCore.Interfaces.Repository;
using TravelWebBackEndCore.Mappers;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly ApplicationDbContext _context;
        public BookingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Booking booking)
        {
            await _context.Bookings.AddAsync(booking);
        }

        public async Task<IQueryable<Booking>> FindBookingsByUserIdAsync(int userId)
        {
            return await Task.FromResult(_context.Bookings
                .Where(b => b.UserId == userId && !b.IsDeleted));
        }

        public async Task<Booking?> FindByIdAsync(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);

            if (booking == null)
            {
                return null;
            }

            return booking;
        }

        public Task<IQueryable<Booking>> getBookings()
        {
            var bookings = _context.Bookings
                .Include(b => b.User)
                .Include(b => b.TourPackage)
                .Include(b => b.Contact)
                .Include(b => b.Payment)
                .Include(b => b.Travelers)
                .Where(b => !b.IsDeleted);
            return Task.FromResult(bookings);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
