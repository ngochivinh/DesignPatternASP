namespace DesignPatternASP.DesignPattern.FactoryMethod
{
    public class ChartProviderFree : IChartProvider
    {
        public IChart GetChart()
        {
            IChart chart = new BarChart();
            return chart;
        }
    }
}
