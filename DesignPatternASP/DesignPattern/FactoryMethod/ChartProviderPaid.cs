namespace DesignPatternASP.DesignPattern.FactoryMethod
{
    public class ChartProviderPaid:IChartProvider
    {
        public IChart GetChart()
        {
            IChart chart = new PieChart();
            return chart;
        }
    }
}
