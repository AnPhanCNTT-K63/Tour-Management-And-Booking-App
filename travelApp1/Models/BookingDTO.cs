using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travelApp1.Models
{
    public class BookingDTO
    {
        public string bookingDate { get; set; }
        public string status { get; set; }
        public int numOfPeople { get; set; }
        public int? tourPackageId { get; set; }
    }
}
