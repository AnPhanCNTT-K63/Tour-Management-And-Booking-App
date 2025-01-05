using System.ComponentModel.DataAnnotations;

namespace TravelWebBackEndCore.DTOs.Tour
{
    public class CreateTourDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Region { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }
        public string Image { get; set; }
        [Required]
        public string Description { get; set; }

        public DateTime Opening { get; set; }
        public DateTime Ending { get; set; }
    }
}
