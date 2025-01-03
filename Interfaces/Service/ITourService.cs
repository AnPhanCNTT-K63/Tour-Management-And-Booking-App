using Microsoft.AspNetCore.Mvc;
using TravelWebBackEndCore.DTOs.Tour;
using TravelWebBackEndCore.Helpers;

namespace TravelWebBackEndCore.Interfaces.Service
{
    public interface ITourService
    {
        Task<(List<TourDTO> Tours, int TotalCount)> GetAllAsync(int page, int pageSize, QueryTour query);
        Task<TourDTO?> GetTourByIdAsync(int id);
        Task<IActionResult> CreateTourWithPackageAsync(CreateTourWithPackageDTO dto);
        Task<IActionResult> SoftDeleteAsync(int id);
        Task<IActionResult> RestoreAsync(int id);
        Task<IActionResult> DeltedAsync(int id);
    }
}
