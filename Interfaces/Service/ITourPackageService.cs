using TravelWebBackEndCore.DTOs.TourPackage;

namespace TravelWebBackEndCore.Interfaces.Service
{
    public interface ITourPackageService
    {
        Task<string> UpdateAsync(int id, UpdatePackageDTO packageDTO);
        Task<PackageDTO?> GetById(int id);
        Task<List<PackageDTO>?> GetByTourId(int tour_id);
        Task<string> DeleteAsync(int id);
    }
}
