public class NewsStory : NewsHandlerSubject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NewsStory"/> class.
    /// </summary>
    public NewsStory()
        : base(string.Empty, Location.London)
    { }

    /// <inheritdoc/>
    public void Report(string story, Location location)
    {
        this.Story = story;
        this.Location = location;
    }
}
