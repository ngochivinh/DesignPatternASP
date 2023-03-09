namespace DesignPatternASP.SOLID.ISP
{
    public interface IOnlineOrderProcessor
    {
        bool ValidateCardInfo(CardInfo obj);
    }
}
