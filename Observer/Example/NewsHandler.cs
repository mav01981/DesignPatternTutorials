using System.Collections.Generic;


/// <summary>
/// Concrete Subject - Publisher
/// </summary>
public abstract class NewsHandler
{
    private List<INewsProvider> _newsProviders = new List<INewsProvider>();

    private string _story;
    private Location _location;
    public NewsHandler(string story, Location location)
    {
        _location = location;
        _story = story;
    }

    public void Subscribe(INewsProvider newsProvider)
    {
        _newsProviders.Add(newsProvider);
    }

    public void UnSubscribe(INewsProvider newsProvider)
    {
        _newsProviders.Remove(newsProvider);
    }
    public void Notify()
    {
        foreach (INewsProvider newsProvider in _newsProviders)
        {
            newsProvider.Update(this);
        }
    }

    public string Story
    {
        get { return _story; }
        set
        {
            if (_story != value)
            {
                _story = value;
                Notify();
            }
        }
    }

    public Location Location
    {
        get { return _location; }
        set
        {
            if (_location != value)
            {
                _location = value;
                Notify();
            }
        }
    }
}
