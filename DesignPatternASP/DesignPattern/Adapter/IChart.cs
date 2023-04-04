using System.Drawing;

namespace DesignPatternASP.DesignPattern.Adapter
{
    public interface IChart
    {
        string Title { get; set; }
        List<string> XData { get; set; }
        List<int> YData {  get; set; }
        Bitmap GenerateChart();
    }
}
