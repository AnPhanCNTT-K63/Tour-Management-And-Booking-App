using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travelApp1.Models
{
    internal class TourResponseDTO
    {
        public List<TourDTO> tours { get; set; }
        public int totalCount { get; set; }
    }
}
