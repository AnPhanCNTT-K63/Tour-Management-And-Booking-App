using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using TravelWebBackEndCore.DTOs.Auth;
using TravelWebBackEndCore.DTOs.User;
using TravelWebBackEndCore.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TravelWebBackEndCore.Interfaces.Repository
{
    public interface IAuthRepository
    {
        Task SaveChangesAsync();
    }
}
