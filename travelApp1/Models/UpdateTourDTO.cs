using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travelApp1.Models
{
    public class UpdateTourDTO
    {
        public string? Name { get; set; }
        public string? Region { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
        public DateTime? Opening { get; set; }
        public DateTime? Ending { get; set; }
    }
}
