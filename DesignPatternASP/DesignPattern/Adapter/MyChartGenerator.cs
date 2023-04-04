using System.Drawing;

namespace DesignPatternASP.DesignPattern.Adapter
{
    public class MyChartGenerator : IChart
    {
        public string Title { get ; set ; }
        public List<string> XData { get ; set ; }
        public List<int> YData { get ; set ; }

        public Bitmap GenerateChart()
        {
            Bitmap chart = new Bitmap("");
            return chart;
        }
    }
}
