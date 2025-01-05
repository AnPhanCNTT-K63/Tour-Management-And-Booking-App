using System.ComponentModel.DataAnnotations;
using TravelWebBackEndCore.DTOs.TourPackage;

namespace TravelWebBackEndCore.DTOs.Tour
{
    public class CreateTourWithPackageDTO
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public CreateTourDTO TourDTO { get; set; }
       [Required]
       public List<CreatePackageDTO> CreatePackageDTO { get; set; }
    }
}
