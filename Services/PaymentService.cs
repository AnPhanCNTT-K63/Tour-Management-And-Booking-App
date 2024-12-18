using TravelWebBackEndCore.Data;
using TravelWebBackEndCore.DTOs.Payment;
using TravelWebBackEndCore.Interfaces.Service;
using TravelWebBackEndCore.Mappers;

namespace TravelWebBackEndCore.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly ApplicationDbContext _context;
        public PaymentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> CreateAsync(CreatePaymentDTO paymentDTO)
        {
            try
            {
                var booking = await _context.Bookings.FindAsync(paymentDTO.BookingId);

                if (booking == null)
                {
                    return "Booking not found";
                }

                await _context.Payments.AddAsync(paymentDTO.ToPayment());
                await _context.SaveChangesAsync();
                return "Payment created successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
