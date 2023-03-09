namespace DesignPatternASP.SOLID.OpenClose
{
    public class TaxCalculator
    {
        public decimal Calculate(ICountryTaxCalculator countryTaxCalculator)
        {
            decimal taxAmount = countryTaxCalculator.CalculateTaxAmount();
            return taxAmount;
        }
    }
}
