using Microsoft.AspNetCore.Mvc;
using TravelWebBackEndCore.DTOs.TourPackage;

namespace TravelWebBackEndCore.Interfaces.Service
{
    public interface ITourPackageService
    {
        Task<IActionResult> UpdateAsync(int id, UpdatePackageDTO packageDTO);
        Task<PackageDTO?> GetById(int id);
        Task<List<PackageDTO>?> GetByTourId(int tour_id);
        Task<IActionResult> DeleteAsync(int id);
    }
}
