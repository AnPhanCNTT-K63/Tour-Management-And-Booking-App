
using Microsoft.AspNetCore.Mvc;
using TravelWebBackEndCore.DTOs.Tour;
using TravelWebBackEndCore.Helpers;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Interfaces.Repository
{
    public interface ITourRepository
    {
        Task<Tour?> FindByIdAsync(int id);
        Task AddAsync(Tour tour);
        void RemoveAsync(Tour tour);
        IQueryable<Tour> FindAll();
        Task SaveChangesAsync();
    }
}
