using Strategy.Example;

namespace Strategy
{
    public class Translator
    {
        public static string Translate(string phrase, ITranslationStrategy strategy)
        {
            return strategy.Translate(phrase);
        }
    }
}
