using TravelWebBackEndCore.DTOs.UserProfile;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Mappers
{
    public static class ProfileMapper
    {
        public static ProfileDTO ToProfileDTO(this UserProfile userProfile)
        {
            return new ProfileDTO
            {
                FirstName = userProfile.FirstName ?? string.Empty,
                LastName = userProfile.LastName ?? string.Empty,
                Address = userProfile.Address ?? string.Empty,
                City = userProfile.City ?? string.Empty,
                Country = userProfile.Country ?? string.Empty,
                PostalCode = userProfile.PostalCode ?? 0,
                AboutMe = userProfile.AboutMe ?? string.Empty,
                Avatar = userProfile.Avatar ?? string.Empty,
                Phone = userProfile.Phone ?? string.Empty,
                Birthday = userProfile.Birthday ?? DateTime.MinValue,
                UserId = userProfile.UserId
            };
        }
    }
}
