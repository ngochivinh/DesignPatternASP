using System.Drawing.Imaging;
using System.Drawing;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatternASP.DesignPattern.FactoryMethod
{
    public class Main
    {
        public byte[] GetImageFree() 
        {
            ChartProviderFree cp = new ChartProviderFree();
            IChart chart = cp.GetChart();
            chart.Title = "Hours per day";
            List<string> xdata = new List<string>();
            xdata.Add("Mon");
            xdata.Add("Tue");
            xdata.Add("Wed");
            xdata.Add("Thu");
            xdata.Add("Fri");
            xdata.Add("Sat");
            xdata.Add("Sun");

            List<int> ydata = new List<int>();
            ydata.Add(12);
            ydata.Add(7);
            ydata.Add(4);
            ydata.Add(10);
            ydata.Add(3);
            ydata.Add(11);
            ydata.Add(5);
            chart.XData = xdata;
            chart.YData = ydata;
            Bitmap bmp = chart.GenerateChart();
            MemoryStream stream = new MemoryStream();
            bmp.Save(stream, ImageFormat.Png);
            byte[] data = stream.ToArray();
            stream.Close();
            return data;
        }
    }
}
