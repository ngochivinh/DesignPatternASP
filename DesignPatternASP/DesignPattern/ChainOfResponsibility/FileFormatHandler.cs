namespace DesignPatternASP.DesignPattern.ChainOfResponsibility
{
    public class FileFormatHandler : IHandler
    {
        public IHandler NextHandler { get ; set ; }

        public void Process(string fileName, string fileContent)
        {
            string ext = Path.GetExtension(fileName);
            if (ext != ".txt" && ext != ".csv")
            {
                throw new Exception("Invalid file type!");
            }
            else
            {
                string[] records = fileContent.Split(new string[] { "\r\n" },
                StringSplitOptions.RemoveEmptyEntries);
                if (records == null || records.Length == 0)
                {
                    throw new Exception("Invalid data!");
                }
                else
                {
                    string[] cols = records[0].Split(',');
                    if (cols.Length != 5)
                    {
                        throw new Exception("Missing or incomplete data!");
                    }
                }
            }

            if(NextHandler != null)
            {
                NextHandler.Process(fileName, fileContent);
            }
        }
    }
}
