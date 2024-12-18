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
    }
}
