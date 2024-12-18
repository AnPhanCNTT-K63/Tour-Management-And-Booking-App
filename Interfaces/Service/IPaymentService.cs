using Microsoft.AspNetCore.Mvc;
using TravelWebBackEndCore.DTOs.Payment;

namespace TravelWebBackEndCore.Interfaces.Service
{
    public interface IPaymentService
    {
        Task<IActionResult> CreateAsync(CreatePaymentDTO paymentDTO);
    }
}
