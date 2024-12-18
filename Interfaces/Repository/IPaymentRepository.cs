using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Interfaces.Repository
{
    public interface IPaymentRepository
    {
        Task AddPaymentAsync(Payment payment);
        Task SaveChangesAsync();
    }
}
