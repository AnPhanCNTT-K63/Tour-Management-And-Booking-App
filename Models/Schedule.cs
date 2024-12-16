using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TravelWebBackEndCore.Models
{
    [Table("Schedule")]
    public class Schedule
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public DateTime? TravelDay { get; set; }
        public int? TourPackageId { get; set; }
        public TourPackage? TourPackage { get; set; }
    }
}
