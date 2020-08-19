namespace Strategy.Example
{
    /// <summary>
    /// Concrete Strategy
    /// </summary>
    public class SpanishTranslator : ITranslationStrategy
    {
        public string Translate(string phrase)
        {
            return $"{nameof(SpanishTranslator)}:Hola";
        }
    }
}
