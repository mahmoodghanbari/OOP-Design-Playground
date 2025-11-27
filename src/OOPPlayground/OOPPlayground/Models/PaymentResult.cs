using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPlayground.Models
{
    public class PaymentResult
    {
        public bool Success { get; set; }
        public string PaymentId { get; set; }
        public string RedirectUrl { get; set; }
        public string ErrorMessage { get; set; }
    }
}
