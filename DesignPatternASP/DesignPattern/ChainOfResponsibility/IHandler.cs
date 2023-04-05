namespace DesignPatternASP.DesignPattern.ChainOfResponsibility
{
    public interface IHandler
    {
        IHandler NextHandler { get; set; }
        void Process(string fileName, string fileContent);
    }
}
