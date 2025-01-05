using System.ComponentModel.DataAnnotations;
using TravelWebBackEndCore.DTOs.Schedule;
using TravelWebBackEndCore.DTOs.Voucher;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.DTOs.TourPackage
{
    public class UpdatePackageDTO
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public string? Image { get; set; }
        public decimal Price { get; set; }
        public string Activities { get; set; }
        public bool IsChangeSchedule { get; set; }
        public bool IsRefund { get; set; }
        public string CheckIn { get; set; }
        public decimal VAT { get; set; }
        public int Quantity { get; set; }
        public List<UpdateScheduleDTO>? Schedules { get; set; }
        public List<UpdateVoucherDTO>? Vouchers { get; set; }

    }
}
