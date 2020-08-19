namespace Strategy.Example
{
    /// <summary>
    /// Concrete Strategy
    /// </summary>
    public class EnglishTranslator : ITranslationStrategy
    {
        public string Translate(string phrase)
        {
            return $"{nameof(EnglishTranslator)}:Hello";
        }
    }
}
