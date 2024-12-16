using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelWebBackEndCore.Models
{
    [Table("Tour")]
    public class Tour
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = new string("No name");
        public string Region { get; set; } = new string("No region");
        public string Country { get; set; } = new string("No country");
        public string City { get; set; } = new string("No city");
        public string Image { get; set; } = new string("No image");
        public string Description { get; set; } = new string("No description");
        public int UserId { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? Opening { get; set; }
        public DateTime? Ending { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public ICollection<TourPackage>? TourPackages { get; set; }
        public User User { get; set; }
    }
}
