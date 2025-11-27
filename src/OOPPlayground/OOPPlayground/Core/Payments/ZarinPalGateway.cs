using OOPPlayground.Core.Logging;
using OOPPlayground.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPlayground.Core.Payments
{
    public class ZarinPalGateway : PaymentProcessor
    {
        public ZarinPalGateway(ILogger logger) : base(logger) { }

        public override Task<PaymentResult> ChargeAsync(PaymentRequest request)
        {
            // Simulate ZarinPal processing
            Log(request.Amount, "ZarinPal");
            var result = new PaymentResult
            {
                Success = true,
                PaymentId = $"ZP-{System.Guid.NewGuid()}",
                RedirectUrl = $"https://zarinpal.example/pay/{request.OrderId}"
            };
            return Task.FromResult(result);
        }
    }
}
