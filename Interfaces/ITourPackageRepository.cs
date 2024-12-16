using TravelWebBackEndCore.DTOs.Tour;
using TravelWebBackEndCore.DTOs.TourPackage;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Interfaces
{
    public interface ITourPackageRepository
    {
        Task<string> UpdateAsync(int id, UpdatePackageDTO packageDTO);
        Task<PackageDTO?> GetById(int id);
        Task<List<PackageDTO>?> GetByTourId(int tour_id);
        Task<string> DeleteAsync(int id);
    }
}
