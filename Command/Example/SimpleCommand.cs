using Microsoft.Extensions.Logging;

namespace Command.Example
{
    public class SimpleCommand : ICommand
    {
        private readonly Receiver _receiver;
        private string _message;
        private ILogger _logger;

        public SimpleCommand(ILogger logger, Receiver receiver, string message)
        {
            _logger = logger;
            _receiver = receiver;
            _message = message;
        }
        public void Execute()
        {
            _logger.LogInformation($"{nameof(SimpleCommand)}:{_message}");

            _receiver.SendEmail();
            _receiver.CreateReport();
        }
    }
}
