
using System;

/// <summary>
/// Concrete Observer
/// </summary>
public class NewsProvider : INewsProvider
{
    private string _name;
    public NewsProvider(string name)
    {
        _name = name;
    }
    public void Update(NewsHandler newsHandler)
    {
        Console.WriteLine($"{_name}  {newsHandler.Story} in {newsHandler.Location}");
    }
}
