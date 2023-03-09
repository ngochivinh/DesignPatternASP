namespace DesignPatternASP.SOLID.ISP
{
    public interface IOrderProcessor
    {
        bool ValidateShippingAddress(Address obj);
        void ProcessOrder(Order obj);
    }
}
