using System.ComponentModel.DataAnnotations;
using TravelWebBackEndCore.DTOs.Schedule;
using TravelWebBackEndCore.DTOs.Voucher;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.DTOs.TourPackage
{
    public class UpdatePackageDTO
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public string Image { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string Activities { get; set; }
        public bool IsChangeSchedule { get; set; }
        public bool IsRefund { get; set; }
        [Required]
        public string CheckIn { get; set; }
        [Required]
        public decimal VAT { get; set; }
        [Required]
        public int Quantity { get; set; }
        public List<UpdateScheduleDTO>? Schedules { get; set; }
        public List<UpdateVoucherDTO>? Vouchers { get; set; }

    }
}
