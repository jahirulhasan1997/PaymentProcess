using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentProcess.Factory;
using PaymentProcess.Strategies;

namespace PaymentProcess.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentFactory _paymentFactory;
        public PaymentController(IPaymentFactory paymentFactory)
        {
            _paymentFactory = paymentFactory;
        }
        [HttpPost]
        public IActionResult ProcessPayment(string method, decimal amount)
        {         
            try
            {
                IPaymentStrategy paymentStrategy = _paymentFactory.GetPaymentStrategy(method);
                paymentStrategy.Pay(amount);
                return Ok($"Payment of {amount} done with {method}");

            }catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                throw new Exception("Internal Server Error");
            }
        }
    }
}
