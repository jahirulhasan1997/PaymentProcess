
namespace PaymentProcess.Strategies
{
    public class CryptoCurrencyPayment : IPaymentStrategy
    {
        public Task Pay(decimal amount)
        {
            Task.Run(() =>
            {
                Console.WriteLine("Pay amount : " + amount);
            });

            Task.CompletedTask.Wait();
            return Task.FromResult(0);
        }
    }
}
