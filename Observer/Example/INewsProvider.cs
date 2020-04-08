public interface INewsProvider
{
    string Name { get; }

    void Update(NewsHandler newsHandler);
}
