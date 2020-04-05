using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //World News.
            //Interface Subject: 
            //Concrete Subject: NewsStory ie Publisher
            //Interface Subject:
            //Concreate Observer: News Paper Provider ie subscriber (Multiple)

            var reporter = new NewsStory("", Location.London);

            var timesProvider = new NewsProvider("New York Times");

            reporter.Subscribe(new NewsProvider("Times"));
            reporter.Subscribe(new NewsProvider("The Herald"));
            reporter.Subscribe(new NewsProvider("The Sun"));
            reporter.Subscribe(timesProvider);

            reporter.Report("England win the World Cup !", Location.London);

            reporter.UnSubscribe(timesProvider);

            reporter.Report("UFO Sightings near  !", Location.London);
        }
    }
}
