namespace Strategy.Example
{
    /// <summary>
    /// Concrete Strategy
    /// </summary>
    public class FrenchTranslator : ITranslationStrategy
    {
        public string Translate(string phrase)
        {
            return $"{nameof(FrenchTranslator)}:Bonjour";
        }
    }
}
