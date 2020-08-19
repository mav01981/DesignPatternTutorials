namespace Strategy.Example
{
    /// <summary>
    /// Concrete Strategy
    /// </summary>
    public class GermanTranslator : ITranslationStrategy
    {
        public string Translate(string phrase)
        {
            return $"{nameof(GermanTranslator)}:Hallo";
        }
    }
}
