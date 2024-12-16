using TravelWebBackEndCore.DTOs.Payment;

namespace TravelWebBackEndCore.Interfaces
{
    public interface IPaymentRepository
    {
        Task<string> CreateAsync(CreatePaymentDTO paymentDTO);
    }
}
