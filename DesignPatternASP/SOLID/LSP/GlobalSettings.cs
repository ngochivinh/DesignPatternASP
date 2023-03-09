namespace DesignPatternASP.SOLID.LSP
{
    public class GlobalSettings : IReadableSettings, IWritableSettings
    {
        public Dictionary<string, string> GetSettings()
        {
            Dictionary<string, string> settings = new Dictionary<string, string>();
            settings.Add("Theme", "Summer");
            return settings;
        }

        public string SetSetting(Dictionary<string, string> settings)
        {
            foreach (var item in settings)
            {
                //save to database
            }
            return "Global settings saved on " + DateTime.Now;
        }
    }
}
