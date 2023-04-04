using DesignPatternASP.DesignPattern.AbstractFactory;

namespace DesignPatternASP.DesignPattern.Bridge
{
    public class XmlErrorLogger : IErrorLogger
    {
        public void Log(string message)
        {
            message = $"<error><message>{message}</message><timestamp>{DateTime.Now}</timestamp></error>";
            File.AppendAllText(AppSettings.LogFileFolder + "/errorlog.xml", message);
        }
    }
}
