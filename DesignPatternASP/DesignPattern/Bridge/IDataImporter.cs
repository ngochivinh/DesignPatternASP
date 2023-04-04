namespace DesignPatternASP.DesignPattern.Bridge
{
    public interface IDataImporter
    {
        IErrorLogger ErrorLogger { get; set; }
        void Import(List<Customer> data);
    }
}
