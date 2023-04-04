namespace DesignPatternASP.DesignPattern.Flyweight
{
    public interface IWebsiteStats
    {
        int Id { get; set; }
        string Host { get; set; }
        int PageViews { get; set; }
        int SiteVisit { get; set; }
        string TopKeywords { get; set; }
        int Bandwidth { get; set; }
        int GetActiveUsers();
    }
}
