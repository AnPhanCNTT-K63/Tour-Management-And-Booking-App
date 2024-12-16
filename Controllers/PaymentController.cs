using Microsoft.AspNetCore.Mvc;
using TravelWebBackEndCore.DTOs.Payment;
using TravelWebBackEndCore.Interfaces;

namespace TravelWebBackEndCore.Controllers
{
    [Route("api/payment")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentRepository _paymentRepository;
        public PaymentController(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateAsync([FromBody] CreatePaymentDTO paymentDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _paymentRepository.CreateAsync(paymentDTO);

            if (result == "Booking not found")
            {
                return NotFound(result);
            }

            if (result != "Payment created successfully")
            {
                return BadRequest(result);
            }

            return Ok(result);
        }
    }
}
