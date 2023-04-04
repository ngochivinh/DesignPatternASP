namespace DesignPatternASP.DesignPattern.Flyweight
{
    public class WebsiteStats : IWebsiteStats
    {
        public int Id { get ; set ; }
        public string Host { get ; set ; }
        public int PageViews { get ; set ; }
        public int SiteVisit { get ; set ; }
        public string TopKeywords { get ; set ; }
        public int Bandwidth { get ; set ; }

        public int GetActiveUsers()
        {
            return new Random().Next(0, 100);
        }
    }
}
