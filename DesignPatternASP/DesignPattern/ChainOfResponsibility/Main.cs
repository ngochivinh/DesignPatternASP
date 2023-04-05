namespace DesignPatternASP.DesignPattern.ChainOfResponsibility
{
    public class Main 
    {
        public void Upload(string fileName, string fileContent) 
        {
            FileFormatHandler handler1 = new FileFormatHandler();
            FileStorageHandler handler2 = new FileStorageHandler();
            DataImportHandler handler3 = new DataImportHandler();

            handler1.NextHandler = handler2;
            handler2.NextHandler = handler3;
            handler3.NextHandler = null;

            handler1.Process(fileName,fileContent);
        }
    }
}
