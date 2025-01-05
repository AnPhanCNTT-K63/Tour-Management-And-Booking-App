using System.ComponentModel.DataAnnotations;
using TravelWebBackEndCore.DTOs.Schedule;
using TravelWebBackEndCore.DTOs.Voucher;

namespace TravelWebBackEndCore.DTOs.TourPackage
{
    public class PackageDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public string Image { get; set; }
        [Required]
        public decimal Price { get; set; }
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
        public int TourId { get; set; }
        public List<ScheduleDTO>? Schedules { get; set; }
        public List<VoucherDTO>? Vouchers { get; set; }

    }
}
