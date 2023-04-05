namespace DesignPatternASP.DesignPattern.ChainOfResponsibility
{
    public class DataImportHandler : IHandler
    {
        public IHandler NextHandler { get; set; }

        public void Process(string fileName, string fileContent)
        {
            //Handler Import Data
            if (NextHandler != null)
            {
                NextHandler.Process(fileName, fileContent);
            }
        }
    }
}
