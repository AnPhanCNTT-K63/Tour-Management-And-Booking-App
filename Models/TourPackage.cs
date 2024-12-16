using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TravelWebBackEndCore.Models
{
    [Table("TourPackage")]
    public class TourPackage
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = new string("No name");
        public string Description { get; set; } = new string("No description");
        public string Image { get; set; } = new string("No image");
        public decimal Price { get; set; }
        public string Activities { get; set; } = new string("No activities");
        public bool IsChangeSchedule { get; set; }
        public bool IsRefund { get; set; }
        public string CheckIn { get; set; } = new string("No check in method");
        public decimal VAT { get; set; }
        public int Quantity { get; set; }
        public int TourId { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public Tour? Tour { get; set; }
        public ICollection<Booking>? Bookings { get; set; }
        public ICollection<Schedule>? Schedules { get; set; }
        public ICollection<Voucher>? Vouchers { get; set; }
    }
}
