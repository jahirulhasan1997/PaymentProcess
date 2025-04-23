namespace PaymentProcess.Strategies
{
    public interface IPaymentStrategy
    {
        public Task Pay(decimal amount);
    }
}
