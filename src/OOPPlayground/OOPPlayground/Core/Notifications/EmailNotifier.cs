using OOPPlayground.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPlayground.Core.Notifications
{
    public class EmailNotifier : INotifier
    {
        private readonly ILogger _logger;

        public EmailNotifier(ILogger logger)
        {
            _logger = logger;
        }

        public void Send(string to, string message)
        {
            // Simulate email sending
            _logger.Log($"Sending EMAIL to {to}: {message}");
            Console.WriteLine($"[EMAIL] delivered to {to}");
        }
    }
}
