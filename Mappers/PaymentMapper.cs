using TravelWebBackEndCore.DTOs.Payment;
using TravelWebBackEndCore.DTOs.TourPackage;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Mappers
{
    public static class PaymentMapper
    {
        public static Payment ToPayment(this CreatePaymentDTO paymentDTO)
        {
            return new Payment
            {
                PaymentDate = paymentDTO.PaymentDate,
                PaymentMethod = paymentDTO.PaymentMethod,
                PaymentAmount = paymentDTO.PaymentAmount,
                BookingId = paymentDTO.BookingId
            };
        }
    }
}
