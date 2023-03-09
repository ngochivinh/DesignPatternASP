namespace DesignPatternASP.SOLID.ISP
{
    public class CashOnDeliveryOrderProcessor
    {
        public bool ValidateShippingAddress(Address obj)
        {
            //validate shipping destination
            return true;
        }
        public void ProcessOrder(Order obj)
        {
            //do something with obj
        }
    }
}
