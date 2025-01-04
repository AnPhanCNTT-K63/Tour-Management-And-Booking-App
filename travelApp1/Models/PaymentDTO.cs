using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travelApp1.Models
{
    internal class PaymentDTO
    {
        public string UserId { get; set; }
        public string BookingId { get; set; }
        public string PackageId { get; set; }
        public string Username { get; set; }
        public string TourId { get; set; }
        public string Method { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }
        public string TotalPrice { get; set; }
    }
}
