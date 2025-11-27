using OOPPlayground.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPlayground.Core.Notifications
{
    public class SmsNotifier : INotifier
    {
        private readonly ILogger _logger;

        public SmsNotifier(ILogger logger)
        {
            _logger = logger;
        }

        public void Send(string to, string message)
        {
            // Simulate SMS sending
            _logger.Log($"Sending SMS to {to}: {message}");
            Console.WriteLine($"[SMS] delivered to {to}");
        }
    }
}
