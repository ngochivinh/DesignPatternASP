namespace DesignPatternASP.SOLID.ISP
{
    public class OnlineOrderProcessor
    {
        public bool ValidateCardInfo(CardInfo obj)
        {
            //validate credit card information
            return true;
        }
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
