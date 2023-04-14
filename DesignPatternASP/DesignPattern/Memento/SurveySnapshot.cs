using System.Runtime.Serialization.Formatters.Binary;

namespace DesignPatternASP.DesignPattern.Memento
{
    public class SurveySnapshot
    {
        private string fileName { get; set; }

        public SurveySnapshot(string fileName)
        {
            this.fileName = fileName;
        }

        public void Save(SurveyState surveyState)
        {
            FileStream fileStream = new FileStream(fileName, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, surveyState);
            fileStream.Close();
        }

        public SurveyState Restore()
        {
            FileStream stream = new FileStream(fileName, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            object obj = formatter.Deserialize(stream);
            stream.Close();
            return (SurveyState)obj;
        }
    }
}
