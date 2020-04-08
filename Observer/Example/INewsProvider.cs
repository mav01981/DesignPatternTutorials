public interface INewsProvider
{
    string Name { get; }

    void Update(NewsHandlerSubject newsHandler);
}
