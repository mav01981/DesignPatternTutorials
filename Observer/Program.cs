namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // World News.
            // Interface Subject:
            // Concrete Subject: NewsStory ie Publisher
            // Interface Subject:
            // Concreate Observer: News Paper Provider ie subscriber (Multiple)
            var reporter = new NewsStory();

            reporter.Subscribe(new NewsProviderObserver("Times"));
            reporter.Subscribe(new NewsProviderObserver("The Herald"));
            reporter.Subscribe(new NewsProviderObserver("The Sun"));
            reporter.Subscribe(new NewsProviderObserver("New York Times"));

            reporter.Report("England win the World Cup !", Location.London);

            reporter.UnSubscribe(new NewsProviderObserver("New York Times"));

            reporter.Report("UFO Sightings near  !", Location.London);
        }
    }
}
