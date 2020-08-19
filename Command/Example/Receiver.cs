using Microsoft.Extensions.Logging;

namespace Command.Example
{
    public class Receiver
    {
        private ILogger _logger;

        public Receiver(ILogger logger)
        {
            _logger = logger;
        }

        public void SendEmail()
        {
            _logger.LogInformation($" {nameof(Receiver)}:Email Sent.");
        }

        public void CreateReport()
        {
            _logger.LogInformation($"{nameof(Receiver)}:Report Created.");
        }
    }
}
