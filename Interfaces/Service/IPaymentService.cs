using TravelWebBackEndCore.DTOs.Payment;

namespace TravelWebBackEndCore.Interfaces.Service
{
    public interface IPaymentService
    {
        Task<string> CreateAsync(CreatePaymentDTO paymentDTO);
    }
}
