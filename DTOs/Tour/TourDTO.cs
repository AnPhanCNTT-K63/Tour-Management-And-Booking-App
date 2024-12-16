using TravelWebBackEndCore.DTOs.TourPackage;

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
        public DateTime? Opening { get; set; }
        public DateTime? Ending { get; set; }
        public ICollection<PackageDTO>? TourPackages { get; set; }
    }
}
