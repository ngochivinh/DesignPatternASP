namespace DesignPatternASP.DesignPattern.ChainOfResponsibility
{
    public class FileStorageHandler : IHandler
    {
        public IHandler NextHandler { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Process(string fileName, string fileContent)
        {
            //Save File

            if (NextHandler != null)
            {
                NextHandler.Process(fileName, fileContent);
            }
        }
    }
}
