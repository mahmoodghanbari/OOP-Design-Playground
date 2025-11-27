using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPlayground.Models
{
    public class PaymentRequest
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; } = "IRR";
        public string ReturnUrl { get; set; }
        public string OrderId { get; set; }
        public string PaymentMethod { get; set; }
    }
}
