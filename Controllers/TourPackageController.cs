using Microsoft.AspNetCore.Mvc;
using TravelWebBackEndCore.Interfaces;

namespace TravelWebBackEndCore.Controllers
{
    [Route("api/package")]
    [ApiController]
    public class TourPackageController : ControllerBase
    {
        private readonly ITourPackageRepository _tourPackageRepository;
        public TourPackageController(ITourPackageRepository tourPackageRepository)
        {
            _tourPackageRepository = tourPackageRepository;
        }


    }
}
