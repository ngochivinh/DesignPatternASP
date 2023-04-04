﻿using DesignPatternASP.DesignPattern.AbstractFactory;

namespace DesignPatternASP.DesignPattern.Bridge
{
    public class TextFileErrorLogger : IErrorLogger
    {
        public void Log(string message)
        {
            msg += $" [{DateTime.Now}]";
            msg += "\r\n";
            File.AppendAllText(AppSettings.LogFileFolder + "/errorlog.txt", message);
        }
    }
}
