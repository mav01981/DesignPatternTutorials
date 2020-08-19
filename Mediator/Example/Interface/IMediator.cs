using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    /// <summary>
    /// Mediator interface.
    /// </summary>
    public interface IMediator
    {
        void SendMessage(object sender, string ev);
    }
}
