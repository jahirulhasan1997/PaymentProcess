using PaymentProcess.Strategies;

namespace PaymentProcess.Factory
{
    public interface IPaymentFactory
    {
        public IPaymentStrategy GetPaymentStrategy(string paymentMethod);
    }
}
