using System;

/// <summary>
/// Concrete Observer.
/// </summary>
public class NewsProvider : INewsProvider
{
    private readonly string name;

    /// <summary>
    /// Initializes a new instance of the <see cref="NewsProvider"/> class.
    /// </summary>
    /// <param name="name">Name of news Provider.</param>
    public NewsProvider(string name)
    {
        this.name = name;
    }

    /// <inheritdoc/>
    public string Name => this.name;

    /// <inheritdoc/>
    public void Update(NewsHandler newsHandler)
    {
        if (newsHandler == null)
        {
            throw new ArgumentNullException(string.Empty);
        }

        Console.WriteLine(value: $"{this.name}  {newsHandler.Story} in {newsHandler.Location}");
    }
}
