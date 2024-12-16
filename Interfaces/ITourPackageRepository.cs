using TravelWebBackEndCore.DTOs.Tour;
using TravelWebBackEndCore.DTOs.TourPackage;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Interfaces
{
    public interface ITourPackageRepository
    {
        Task<string> UpdateAsynce(UpdatePackageDTO packageDTO);
    }
}
