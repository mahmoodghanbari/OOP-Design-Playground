using OOPPlayground.Core.Logging;
using OOPPlayground.Core.Notifications;
using OOPPlayground.Core.Payments;
using OOPPlayground.Models;
using OOPPlayground.Services;

namespace OOPPlayground
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // manual DI wiring for demo
            ILogger logger = new ConsoleLogger();

            // Choose which notifier & payment gateway to use for this demo run
            INotifier notifier = new EmailNotifier(logger); // or new SmsNotifier(logger)
            IPaymentGateway zarin = new ZarinPalGateway(logger);
            IPaymentGateway sep = new SepGateway(logger);

            var checkoutWithZarin = new CheckoutService(zarin, notifier, logger);
            var checkoutWithSep = new CheckoutService(sep, notifier, logger);

            var request = new PaymentRequest
            {
                Amount = 49900m,
                Currency = "IRR",
                OrderId = "ORD-1001",
                ReturnUrl = "https://example.com/return",
                PaymentMethod = "online"
            };

            Console.WriteLine("=== Checkout with ZarinPal ===");
            var r1 = await checkoutWithZarin.CheckoutAsync(request, "user@example.com");
            Console.WriteLine($"Result: {r1.Success}, PaymentId: {r1.PaymentId}\n");

            Console.WriteLine("=== Checkout with SEP ===");
            var r2 = await checkoutWithSep.CheckoutAsync(request, "user@example.com");
            Console.WriteLine($"Result: {r2.Success}, PaymentId: {r2.PaymentId}\n");

            // Demonstrate notifier polymorphism directly
            Console.WriteLine("=== Demonstrate notifiers ===");
            var notifiers = new List<INotifier> { new EmailNotifier(logger), new SmsNotifier(logger) };
            foreach (var n in notifiers)
            {
                n.Send("user@example.com", "This is a test message");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
