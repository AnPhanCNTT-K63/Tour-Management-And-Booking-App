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

        public async Task<IActionResult> GetUserPaymentRequest()
        {
            return await GetPaymentRequests(null);
        }

        public async Task<IActionResult> GetPendingPayment()
        {
            return await GetPaymentRequests("pending");
        }

        public async Task<IActionResult> GetProcessedPayment()
        {
            return await GetPaymentRequests(new[] { "success", "fail" });
        }

        public async Task<IActionResult> GetAcceptedPayment()
        {
            return await GetPaymentRequests("success");
        }

        public async Task<IActionResult> GetNotAcceptedPayment()
        {
            return await GetPaymentRequests("fail");
        }

        public async Task<IActionResult> GetPaymentRequests(object statusFilter)
        {
            try
            {
                var query = await _bookingRepository.getBookings();


                if (statusFilter is string singleStatus)
                {
                    query = query.Where(b => b.Status == singleStatus);
                }
                else if (statusFilter is string[] multipleStatuses)
                {
                    query = query.Where(b => multipleStatuses.Contains(b.Status));
                }
                else
                {
                    query = query.Where(b => b.Status != "cancel");
                }

                var bookings = query
                    .Select(b => new
                    {
                        UserId = b.User.Id,
                        Username = b.Contact.Name,
                        Date = b.CreatedAt.HasValue ? b.CreatedAt.Value.ToLocalTime().ToString("MMMM dd, yyyy hh:mm tt") : "N/A",
                        BookingId = b.Id,
                        PackageId = b.TourPackageId,
                        PackageName = b.TourPackage.Name,
                        TotalPrice = b.Payment.PaymentAmount,
                        Method = b.Payment.PaymentMethod,
                        Status = b.Status,
                    }).ToList();

                return new OkObjectResult(bookings);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }


    }
}
