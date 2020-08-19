using Microsoft.Extensions.Logging;

namespace Mediator
{
    /// <summary>
    /// Concrete Strategy
    /// </summary>
    public class User : BaseComponent
    {
        ILogger _logger;
        private readonly string _name;

        public string Name => _name;
        public User(ILogger logger,string name)
        {
            _logger = logger;
            _name = name;
        }

        public void Greet()
        {
            _logger.LogInformation($"{_name} greets: hello");

            this._mediator.SendMessage(this, "A");
        }

        public void Respond()
        {
            _logger.LogInformation($"{_name} responds: hello");
        }
    }
}
