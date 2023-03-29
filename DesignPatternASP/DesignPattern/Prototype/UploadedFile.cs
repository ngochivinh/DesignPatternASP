using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace DesignPatternASP.DesignPattern.Prototype
{
    [Serializable]
    public class UploadedFile : IUploadedFile
    {
        public string FileName { get ; set ; }
        public long Size { get ; set ; }
        public string ContentType { get ; set ; }
        public DateTime TimeStamp { get ; set ; }
        public byte[] FileContent { get ; set ; }

        public IUploadedFile Clone()
        {
            return (IUploadedFile)this.MemberwiseClone();
        }

        public IUploadedFile DeepCopy()
        {
            if (!this.GetType().IsSerializable)
            {
                throw new Exception("The object is not serializable!");
            }

            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream stream = new MemoryStream();
            //bf.Serialize(stream, this);
            JsonSerializer.Serialize(stream, this);
            stream.Seek(0, SeekOrigin.Begin);
            //IUploadedFile deepcopy = (IUploadedFile)bf.Deserialize(stream);
            IUploadedFile deepcopy = JsonSerializer.Deserialize<IUploadedFile>(stream);
            stream.Close();
            return deepcopy;
        }
    }
}
