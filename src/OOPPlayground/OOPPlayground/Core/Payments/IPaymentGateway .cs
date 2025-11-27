using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPlayground.Core.Payments
{
    public interface IPaymentGateway
    {
        Task<PaymentResult> ChargeAsync(PaymentRequest request);
    }
}
