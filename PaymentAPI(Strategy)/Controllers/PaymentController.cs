using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentAPI_Strategy_.Models;
using PaymentAPI_Strategy_.Services;

namespace PaymentAPI_Strategy_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IServiceProvider _serviceProvider;

        public PaymentController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        [HttpPost("pay")]
        public IActionResult ThanhToan([FromBody] PaymentRequest request)
        {
            IPaymentStrategy paymentStrategy;

            switch (request.PaymentMethod.ToLower())
            {
                case "creditcard":
                    paymentStrategy = _serviceProvider.GetRequiredService<CreditCardPayment>();
                    break;
                case "paypal":
                    paymentStrategy = _serviceProvider.GetRequiredService<PayPalPayment>();
                    break;
                case "cod":
                    paymentStrategy = _serviceProvider.GetRequiredService<CashOnDeliveryPayment>();
                    break;
                default:
                    return BadRequest("Phương thức thanh toán không hợp lệ!");
            }

            var context = new PaymentContext(paymentStrategy);
            var result = context.ThanhToanDonHang(request.Amount);

            return Ok(new { message = result });
        }
    }
}
