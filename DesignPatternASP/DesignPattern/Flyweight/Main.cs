namespace DesignPatternASP.DesignPattern.Flyweight
{
    public class Main
    {
        public IWebsiteStats GetWebsiteStatus(string host)
        {
            WebsiteStatsFactory statsFactory = new WebsiteStatsFactory();
            WebsiteStats stats = (WebsiteStats)statsFactory[host];
            return stats;
        }
    }
}
