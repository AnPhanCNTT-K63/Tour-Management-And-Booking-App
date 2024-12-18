using TravelWebBackEndCore.DTOs.Tour;
using TravelWebBackEndCore.DTOs.TourPackage;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Interfaces.Repository
{
    public interface ITourPackageRepository
    {
        Task<TourPackage?> FindByIdAsync(int id);
        void RemoveAsync(TourPackage tourPackage);
        Task<TourPackage?> GetTourPackageWithDetailsAsync(int id);
        IQueryable<TourPackage?> GetTourPackageDetailsByTourIdAsync(int tour_id);
        Task AddRangeAsync(IEnumerable<TourPackage> tourPackage);
        Task SaveChangesAsync();
    }
}
