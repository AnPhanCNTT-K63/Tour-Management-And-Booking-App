using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travelApp1.Models
{
    internal class QueryTourDTO
    {
        public string? region { get; set; }
        public string? searchBy { get; set; }
        public string? searchQuery { get; set; }
        public string? sortBy { get; set; }
        public int[]? priceRange { get; set; }
    }
}
