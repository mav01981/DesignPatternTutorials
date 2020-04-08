using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Concrete Subject - Publisher
/// </summary>
public abstract class NewsHandlerSubject
{
    private readonly List<INewsProvider> newsProviders = new List<INewsProvider>();

    private string story;
    private Location location;

    /// <summary>
    /// Initializes a new instance of the <see cref="NewsHandlerSubject"/> class.
    /// </summary>
    /// <param name="story">Story.</param>
    /// <param name="location">Location.</param>
    public NewsHandlerSubject(string story, Location location)
    {
        this.location = location;
        this.story = story;
    }

    /// <summary>
    /// Gets or sets story.
    /// </summary>
    public string Story
    {
        get => this.story;

        set
        {
            if (this.story != value)
            {
                this.story = value;
                this.Notify();
            }
        }
    }

    /// <summary>
    /// Gets or sets location.
    /// </summary>
    public Location Location
    {
        get => this.location;

        set
        {
            if (this.location != value)
            {
                this.location = value;
                this.Notify();
            }
        }
    }

    /// <summary>
    /// cscsdc.
    /// </summary>
    /// <param name="newsProvider">Provider.</param>
    public void Subscribe(INewsProvider newsProvider)
    {
        this.newsProviders.Add(newsProvider);
    }

    /// <summary>
    /// UnSubscribe.
    /// </summary>
    /// <param name="provider">Provider.</param>
    public void UnSubscribe(INewsProvider provider)
    {
        this.newsProviders.Remove(this.newsProviders.FirstOrDefault(x => x.Name == provider.Name));
    }

    /// <summary>
    /// Notify.
    /// </summary>
    public void Notify()
    {
        foreach (INewsProvider newsProvider in this.newsProviders)
        {
            newsProvider.Update(this);
        }
    }
}
