using Microsoft.EntityFrameworkCore;
using TravelWebBackEndCore.Data;
using TravelWebBackEndCore.DTOs.Schedule;
using TravelWebBackEndCore.DTOs.TourPackage;
using TravelWebBackEndCore.DTOs.Voucher;
using TravelWebBackEndCore.Interfaces.Repository;
using TravelWebBackEndCore.Interfaces.Service;
using TravelWebBackEndCore.Mappers;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Repositories
{
    public class TourPackageRepository : ITourPackageRepository
    {
        private readonly ApplicationDbContext _context;
        public TourPackageRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<TourPackage?> FindByIdAsync(int id)
        {
            return await _context.TourPackages.FindAsync(id);
        }

        public void RemoveAsync(TourPackage tourPackage)
        {
            _context.Remove(tourPackage);
        }

        public async Task<TourPackage?> GetTourPackageWithDetailsAsync(int id)
        {
            return await _context.TourPackages
                .Include(p => p.Schedules)
                .Include(p => p.Vouchers)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public IQueryable<TourPackage?> GetTourPackageDetailsByTourIdAsync(int tour_id)
        {
            return _context.TourPackages
                .Include(p => p.Schedules)
                .Include(p => p.Vouchers)
                .Where(p => p.TourId == tour_id);
        }

        public async Task AddRangeAsync(IEnumerable<TourPackage> tourPackage)
        {
            await _context.AddRangeAsync(tourPackage);
        }


        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }


    }
}
