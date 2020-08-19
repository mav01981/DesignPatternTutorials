using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Example
{
    /// <summary>
    /// Strategy interface that defines behaviour.
    /// </summary>
    public interface ITranslationStrategy
    {
        string Translate(string phrase);
    }
}
