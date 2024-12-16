
using Microsoft.AspNetCore.Mvc;
using TravelWebBackEndCore.DTOs.Tour;
using TravelWebBackEndCore.Helpers;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Interfaces
{
    public interface ITourRepository
    {
        Task<List<TourDTO>> GetAllAsync(QueryTour query);
        Task<TourDTO?> GetTourByIdAsync(int id);
        Task<string> CreateTourWithPackageAsync(CreateTourWithPackageDTO dto);
    }
}
