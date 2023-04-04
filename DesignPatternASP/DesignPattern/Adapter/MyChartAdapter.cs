using System.Drawing;

namespace DesignPatternASP.DesignPattern.Adapter
{
    public class MyChartAdapter : IChart
    {
        public string Title { get ; set ; }
        public List<string> XData { get ; set ; }
        public List<int> YData { get ; set ; }

        public Bitmap GenerateChart()
        {
            ThirdPartyChartGenerator generator = new ThirdPartyChartGenerator();
            return generator.DrawChart(Title,XData,YData);
        }
    }
}
