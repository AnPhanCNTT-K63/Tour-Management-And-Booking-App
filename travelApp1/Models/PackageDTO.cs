using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travelApp1.Models
{
    public class PackageDTO
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public decimal? Price { get; set; }
        public string? Activities { get; set; }
        public bool? IsChangeSchedule { get; set; }
        public bool? IsRefund { get; set; }
        public string? CheckIn { get; set; }
        public int? Quantity { get; set; }
        public decimal? Vat { get; set; }
        public List<ScheduleDTO>? Schedules { get; set; }
        public List<VoucherDTO>? Vouchers { get; set; }

        public string GetValidationError()
        {
            if (string.IsNullOrEmpty(Name)) return "Tên gói không được để trống.";
            if (Price <= 0) return "Giá phải lớn hơn 0.";
            if (Quantity <= 0) return "Số lượng phải lớn hơn 0.";
            if (Vat < 0 || Vat > 5) return "VAT phải nằm trong khoảng từ 0 đến 5.";
            if (string.IsNullOrEmpty(CheckIn)) return "Ngày nhận phòng không được để trống.";
            if (Schedules == null || !Schedules.Any()) return "Phải có ít nhất một lịch trình.";
            if (Vouchers == null || !Vouchers.Any()) return "Phải có ít nhất một voucher.";
            return null;
        }

    }
}
