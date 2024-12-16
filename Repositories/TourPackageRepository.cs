using Microsoft.EntityFrameworkCore;
using TravelWebBackEndCore.Data;
using TravelWebBackEndCore.DTOs.TourPackage;
using TravelWebBackEndCore.Interfaces;
using TravelWebBackEndCore.Mappers;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Repositories
{
    public class TourPackageRepository : ITourPackageRepository
    {
        public Task<string> UpdateAsynce(UpdatePackageDTO packageDTO)
        {
            throw new NotImplementedException();
        }
    }
}
