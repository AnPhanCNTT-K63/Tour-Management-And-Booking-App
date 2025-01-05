using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace travelApp1.Models
{
    public class TourDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } // Tên tour
        public string Region { get; set; } // Khu vực
        public string Country { get; set; } // Quốc gia
        public string City { get; set; } // Thành phố
        public string Image { get; set; } // Link ảnh
        public string Description { get; set; } // Mô tả tour
        public decimal Price { get; set; }
        public DateTime Opening { get; set; } // Ngày bắt đầu
        public DateTime Ending { get; set; } // Ngày kết thúc
        public string GetValidationError()
        {
            if (string.IsNullOrEmpty(Name)) return "Tên tour không được để trống.";
            if (string.IsNullOrEmpty(Region)) return "Khu vực không được để trống.";
            if (string.IsNullOrEmpty(Country)) return "Quốc gia không được để trống.";
            if (string.IsNullOrEmpty(City)) return "Thành phố không được để trống.";
            if (Opening > Ending) return "Ngày bắt đầu phải trước ngày kết thúc.";
            return null; // Không có lỗi
        }
    }
}
