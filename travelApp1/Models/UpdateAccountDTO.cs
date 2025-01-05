using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travelApp1.Models
{
    public class UpdateAccountDTO
    {
        public string? Email { get; set; }
        public string? Username { get; set; }
        public string? NewPassword { get; set; }
        public string? Password { get; set; }
    }
}
