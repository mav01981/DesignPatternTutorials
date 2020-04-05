public class NewsStory : NewsHandler
{
    public NewsStory(string story,
                     Location location)
        : base(story, location)
    {
       
    }

    public void Report(string story, Location location)
    {
        this.Story = story;
        this.Location = location;
    }
}
