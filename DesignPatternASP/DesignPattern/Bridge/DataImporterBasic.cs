namespace DesignPatternASP.DesignPattern.Bridge
{
    public class DataImporterBasic : IDataImporter
    {
        public IErrorLogger ErrorLogger { get;set; }

        public void Import(List<Customer> data)
        {
            try
            {
                foreach (var item in data)
                {
                    //db.Customers.Add(item);
                }
                //db.SaveChanges();
            }
            catch (Exception ex)
            {
                ErrorLogger.Log(ex.Message);
            }
        }
    }
}
