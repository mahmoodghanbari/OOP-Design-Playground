using OOPPlayground.Core.Logging;
using OOPPlayground.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPlayground.Core.Payments
{
    public class SepGateway : PaymentProcessor
    {
        public SepGateway(ILogger logger) : base(logger) { }

        public override Task<PaymentResult> ChargeAsync(PaymentRequest request)
        {
            // Simulate SEP processing
            Log(request.Amount, "SEP");
            var result = new PaymentResult
            {
                Success = true,
                PaymentId = $"SEP-{System.Guid.NewGuid()}",
                RedirectUrl = $"https://sep.example/pay/{request.OrderId}"
            };
            return Task.FromResult(result);
        }
    }
}
