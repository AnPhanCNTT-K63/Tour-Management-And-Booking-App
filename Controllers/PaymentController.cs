using Microsoft.AspNetCore.Mvc;
using TravelWebBackEndCore.DTOs.Payment;
using TravelWebBackEndCore.Interfaces.Service;

namespace TravelWebBackEndCore.Controllers
{
    [Route("api/payment")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateAsync([FromBody] CreatePaymentDTO paymentDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _paymentService.CreateAsync(paymentDTO);

            return result;
        }

        [HttpGet("request")]
        public async Task<IActionResult> GetUserPaymentRequest()
        {
            return await _paymentService.GetUserPaymentRequest();
        }

        [HttpGet("request/pending")]
        public async Task<IActionResult> GetPendingPayment()
        {
            return await _paymentService.GetPendingPayment();
        }

        [HttpGet("request/processed")]
        public async Task<IActionResult> GetProcessedPayment()
        {
            return await _paymentService.GetProcessedPayment();
        }

        [HttpGet("request/accepted")]
        public async Task<IActionResult> GetAcceptedPayment()
        {
            return await _paymentService.GetAcceptedPayment();
        }

        [HttpGet("request/unaccepted")]
        public async Task<IActionResult> GetNotAcceptedPayment()
        {
            return await _paymentService.GetNotAcceptedPayment();
        }
    }
}
