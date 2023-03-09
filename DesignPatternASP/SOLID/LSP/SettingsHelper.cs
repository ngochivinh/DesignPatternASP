namespace DesignPatternASP.SOLID.LSP
{
    public class SettingsHelper
    {
        public static Dictionary<IReadableSettings, Dictionary<string, string>> GetAllSettings(List<IReadableSettings> items) 
        {
            var allSetting = new Dictionary<IReadableSettings, Dictionary<string, string>>();
            foreach (var item in items)
            {
                allSetting.Add(item, item.GetSettings());
            }

            return allSetting;
        }

        public static List<string> SetAllSettings(List<IWritableSettings> items, List<Dictionary<string,string>> values) 
        { 
            List<string> messages= new List<string>();
            for (int i = 0; i < items.Count; i++) 
            {
                messages.Add(items[i].SetSetting(values[i]));
            }
            return messages;
        }
    }
}
