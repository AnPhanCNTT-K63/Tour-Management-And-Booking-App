using Microsoft.EntityFrameworkCore;
using TravelWebBackEndCore.Data;
using TravelWebBackEndCore.Interfaces.Repository;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly ApplicationDbContext _context;

        public PaymentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddPaymentAsync(Payment payment)
        {
            await _context.Payments.AddAsync(payment);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
