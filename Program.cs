using PaymentProcess.Factory;
using PaymentProcess.Strategies;

var builder = WebApplication.CreateBuilder(args);

// Add services to serviceCollection
builder.Services.AddTransient<IPaymentStrategy, CreditCardPayment>();
builder.Services.AddTransient<IPaymentStrategy, PayPalPayment>();
builder.Services.AddTransient<IPaymentStrategy, CryptoCurrencyPayment>();
builder.Services.AddSingleton<IPaymentFactory, PaymentFactory>();


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
