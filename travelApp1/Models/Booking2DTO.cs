using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travelApp1.Models
{
    public class Booking2DTO
    {
        public int Id { get; set; }
        [Required]
        public DateTime BookingDate { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public int NumOfPeople { get; set; }
        [Required]
        public int TourPackageId { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
