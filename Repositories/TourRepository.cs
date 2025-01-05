using Microsoft.EntityFrameworkCore;
using TravelWebBackEndCore.Data;
using TravelWebBackEndCore.DTOs.Tour;
using TravelWebBackEndCore.Helpers;
using TravelWebBackEndCore.Interfaces.Repository;
using TravelWebBackEndCore.Interfaces.Service;
using TravelWebBackEndCore.Mappers;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Repository
{
    public class TourRepository : ITourRepository
    {
        private readonly ApplicationDbContext _context;
        public TourRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Tour tour)
        {
            await _context.Tours.AddAsync(tour);
        }

        public IQueryable<Tour> FindAll()
        {
            return _context.Tours.Where(t => t.IsDeleted == false);
        }

        public async Task<Tour?> FindByIdAsync(int id)
        {
            return await _context.Tours.Include(t => t.User).FirstOrDefaultAsync(t => t.Id == id && t.IsDeleted == false);
        }

        public void RemoveAsync(Tour tour)
        {
            _context.Tours.Remove(tour);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
