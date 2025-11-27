using OOPPlayground.Core.Logging;
using OOPPlayground.Core.Notifications;
using OOPPlayground.Core.Payments;
using OOPPlayground.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPlayground.Services
{
    public class CheckoutService
    {
        private readonly IPaymentGateway _paymentGateway;
        private readonly INotifier _notifier;
        private readonly ILogger _logger;

        public CheckoutService(IPaymentGateway paymentGateway, INotifier notifier, ILogger logger)
        {
            _paymentGateway = paymentGateway;
            _notifier = notifier;
            _logger = logger;
        }

        public async Task<PaymentResult> CheckoutAsync(PaymentRequest request, string notifyTo)
        {
            _logger.Log($"Starting checkout for Order {request.OrderId}");

            var result = await _paymentGateway.ChargeAsync(request);

            if (result.Success)
            {
                _notifier.Send(notifyTo, $"Payment successful. PaymentId: {result.PaymentId}");
                _logger.Log($"Checkout success for Order {request.OrderId}");
            }
            else
            {
                _notifier.Send(notifyTo, $"Payment failed: {result.ErrorMessage}");
                _logger.Log($"Checkout failed for Order {request.OrderId}: {result.ErrorMessage}");
            }

            return result;
        }
    }
}
