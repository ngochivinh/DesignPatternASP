namespace DesignPatternASP.DesignPattern.Flyweight
{
    public class WebsiteStatsFactory
    {
        private static Dictionary<string, WebsiteStats> dictionary = new Dictionary<string, WebsiteStats>();

        public IWebsiteStats this[string host]
        {
            get
            {
                if (!dictionary.ContainsKey(host))
                {
                    var webStats = new WebsiteStats();
                    webStats.Id = 1;
                    webStats.Bandwidth = 0;
                    dictionary.Add(host, webStats);
                }
                return dictionary[host];
            }
        }
    }
}
