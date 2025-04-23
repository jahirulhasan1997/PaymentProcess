using PaymentProcess.Strategies;

namespace PaymentProcess.Factory
{
    public class PaymentFactory : IPaymentFactory
    {
        private readonly IPaymentStrategy CreditCardPayment;
        private readonly IPaymentStrategy PayPalPayment;
        private readonly IPaymentStrategy CryptoCurrencyPayment;

        public PaymentFactory(IPaymentStrategy CreditCardPayment, IPaymentStrategy PayPalPayment, IPaymentStrategy CryptoCurrencyPayment) 
        { 
            this.PayPalPayment = PayPalPayment;
            this.CreditCardPayment = CreditCardPayment;
            this.CryptoCurrencyPayment = CryptoCurrencyPayment;
        }
        public IPaymentStrategy GetPaymentStrategy(string paymentMethod)
        {
            IPaymentStrategy strategy;
            switch (paymentMethod)
            {
                case "CreditCard" : 
                    strategy = CreditCardPayment;
                    break;
                case "PayPal":
                    strategy = PayPalPayment;
                    break;
                case "CryptoPayment":
                    strategy = CryptoCurrencyPayment;
                    break;
                default:
                    throw new ArgumentNullException();
            }

            return strategy;
        }
    }
}
