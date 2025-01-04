using Microsoft.AspNetCore.Mvc;
using TravelWebBackEndCore.DTOs.Payment;

namespace TravelWebBackEndCore.Interfaces.Service
{
    public interface IPaymentService
    {
        Task<IActionResult> CreateAsync(CreatePaymentDTO paymentDTO);
        Task<IActionResult> GetPaymentRequests(object statusFilter);
        Task<IActionResult> GetUserPaymentRequest();
        Task<IActionResult> GetPendingPayment();
        Task<IActionResult> GetProcessedPayment();
        Task<IActionResult> GetAcceptedPayment();
        Task<IActionResult> GetNotAcceptedPayment();
    }
}
