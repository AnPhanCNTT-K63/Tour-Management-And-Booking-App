using TravelWebBackEndCore.DTOs.Payment;
using TravelWebBackEndCore.Interfaces.Repository;
using TravelWebBackEndCore.Interfaces.Service;
using TravelWebBackEndCore.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace TravelWebBackEndCore.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IBookingRepository _bookingRepository;

        public PaymentService(IPaymentRepository paymentRepository, IBookingRepository bookingRepository)
        {
            _paymentRepository = paymentRepository;
            _bookingRepository = bookingRepository;
        }

        public async Task<IActionResult> CreateAsync(CreatePaymentDTO paymentDTO)
        {
            try
            {
                var booking = await _bookingRepository.FindByIdAsync(paymentDTO.BookingId);

                if (booking == null)
                {
                    return new NotFoundObjectResult("Booking not found");
                }

                await _paymentRepository.AddPaymentAsync(paymentDTO.ToPayment());
                await _paymentRepository.SaveChangesAsync();

                return new OkObjectResult("Payment created successfully");
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }
    }
}
