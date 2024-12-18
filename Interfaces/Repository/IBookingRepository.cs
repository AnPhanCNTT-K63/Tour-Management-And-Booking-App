using Microsoft.AspNetCore.Mvc;
using TravelWebBackEndCore.DTOs.Booking;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Interfaces.Repository
{
    public interface IBookingRepository
    {
        Task<Booking?> FindByIdAsync(int id);
        Task<IQueryable<Booking>> FindBookingsByUserIdAsync(int userId);
        Task AddAsync(Booking booking);
        Task SaveChangesAsync();
    }
}
