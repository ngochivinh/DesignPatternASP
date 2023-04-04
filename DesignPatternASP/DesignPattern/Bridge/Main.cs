namespace DesignPatternASP.DesignPattern.Bridge
{
    public class Main
    {
        void Import(List<Customer> records) {
            IDataImporter importer = new DataImporterBasic();
            importer.ErrorLogger = new TextFileErrorLogger();
            importer.Import(records);
        }
    }
}
