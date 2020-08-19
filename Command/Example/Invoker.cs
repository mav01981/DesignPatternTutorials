using Microsoft.Extensions.Logging;

namespace Command.Example
{
    public class Invoker
    {
        private ILogger _logger;
        private ICommand _onStart;
        private ICommand _onFinish;

        public Invoker(ILogger logger)
        {
            _logger = logger;
        }
        
        // Initialize commands.
        public void SetOnStart(ICommand command)
        {
            this._onStart = command;
        }

        public void SetOnFinish(ICommand command)
        {
            this._onFinish = command;
        }

        // The Invoker does not depend on concrete command or receiver classes.
        // The Invoker passes a request to a receiver indirectly, by executing a
        // command.
        public void DoWork()
        {
            _logger.LogInformation($"{nameof(Invoker)}:Executing Commands on Start");
            if (this._onStart is ICommand)
            {
                this._onStart.Execute();
            }

            _logger.LogInformation($"{nameof(Invoker)}:Executing Commands on Finish");
            if (this._onFinish is ICommand)
            {
                this._onFinish.Execute();
            }
        }
    }
}
