using TravelWebBackEndCore.DTOs.Tour;
using TravelWebBackEndCore.Helpers;

namespace TravelWebBackEndCore.Interfaces.Service
{
    public interface ITourService
    {
        Task<List<TourDTO>> GetAllAsync(QueryTour query);
        Task<TourDTO?> GetTourByIdAsync(int id);
        Task<string> CreateTourWithPackageAsync(CreateTourWithPackageDTO dto);
        Task<string> SoftDeleteAsync(int id);
        Task<string> RestoreAsynce(int id);
        Task<string> DeltedAsync(int id);
    }
}
