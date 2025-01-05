using TravelWebBackEndCore.DTOs.Traveler;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Mappers
{
    public static class TravelerMapper
    {
        public static Traveler ToTraveler(this CreateTravelerDTO travelerDTO)
        {
            return new Traveler
            {
                Name = travelerDTO.Name,
                Phone = travelerDTO.Phone,
            };
        }
    }
}
