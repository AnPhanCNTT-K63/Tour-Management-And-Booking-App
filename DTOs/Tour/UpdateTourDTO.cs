using System.ComponentModel.DataAnnotations;

namespace TravelWebBackEndCore.DTOs.Tour
{
    public class UpdateTourDTO
    {
        public string? Name { get; set; }
        public string? Region { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
        public DateTime? Opening { get; set; }
        public DateTime? Ending { get; set; }
    }
}
