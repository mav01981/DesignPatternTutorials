using System.Collections.Generic;

namespace Mediator
{
    /// <summary>
    /// Concrete Mediator 
    /// </summary>
    class ConcreteMediator : IMediator
    {
        private List<User>  _users = new List<User>();

        public ConcreteMediator(List<User> users)
        {
            _users = users;

            foreach (var user in _users)
            {
                user.SetMediator(this);
            }
        }

        public void SendMessage(object sender, string ev)
        {
            if (ev == "A")
            {
                foreach (var user in _users)
                {
                    user.Respond();
                }
            }
            if (ev == "D")
            {
                foreach (var user in _users)
                {
                    user.Greet();
                }
            }
        }
    }
    }
