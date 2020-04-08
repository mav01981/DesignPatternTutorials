using System;

/// <summary>
/// Concrete Observer.
/// </summary>
public class NewsProviderObserver : INewsProvider
{
    private readonly string name;

    /// <summary>
    /// Initializes a new instance of the <see cref="NewsProviderObserver"/> class.
    /// </summary>
    /// <param name="name">Name of news Provider.</param>
    public NewsProviderObserver(string name)
    {
        this.name = name;
    }

    /// <inheritdoc/>
    public string Name => this.name;

    /// <inheritdoc/>
    public void Update(NewsHandlerSubject newsHandler)
    {
        if (newsHandler == null)
        {
            throw new ArgumentNullException(string.Empty);
        }

        Console.WriteLine(value: $"{this.name}  {newsHandler.Story} in {newsHandler.Location}");
    }
}
