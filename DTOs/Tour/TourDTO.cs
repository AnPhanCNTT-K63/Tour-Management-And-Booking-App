using TravelWebBackEndCore.DTOs.TourPackage;
using TravelWebBackEndCore.DTOs.User;

namespace TravelWebBackEndCore.DTOs.Tour
{
    public class TourDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = new string("No name");
        public string Region { get; set; } = new string("No region");
        public string Country { get; set; } = new string("No country");
        public string City { get; set; } = new string("No city");
        public string Image { get; set; } = new string("No image");
        public string Description { get; set; } = new string("No description");
        public decimal Price { get; set; }
        public int UserId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? Opening { get; set; }
        public DateTime? Ending { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public ICollection<PackageDTO>? TourPackages { get; set; }

    }
}
