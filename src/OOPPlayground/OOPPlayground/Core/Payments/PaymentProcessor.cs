using OOPPlayground.Core.Logging;
using OOPPlayground.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPlayground.Core.Payments
{
    public abstract class PaymentProcessor : IPaymentGateway
    {
        protected readonly ILogger _logger;

        protected PaymentProcessor(ILogger logger)
        {
            _logger = logger;
        }

        public abstract Task<PaymentResult> ChargeAsync(PaymentRequest request);

        protected void Log(decimal amount, string gateway)
        {
            _logger.Log($"Payment of {amount:C} processed by {gateway}");
        }
    }
}
