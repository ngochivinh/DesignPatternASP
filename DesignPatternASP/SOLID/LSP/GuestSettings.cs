namespace DesignPatternASP.SOLID.LSP
{
    public class GuestSettings : IReadableSettings
    {
        public Dictionary<string, string> GetSettings()
        {
            Dictionary<string, string> settings = new Dictionary<string, string>();
            settings.Add("GuestName", "John");
            return settings;
        }
    }
}
