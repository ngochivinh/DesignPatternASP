using System.Net.Http.Headers;

namespace DesignPatternASP.DesignPattern.Prototype
{
    public class Main
    {
        public void Upload(IList<IFormFile> files)
        {
            foreach (var file in files)
            {
                ContentDispositionHeaderValue header = ContentDispositionHeaderValue.Parse(file.ContentDisposition);
                string fileName = header.FileName;
                fileName = fileName.Trim('"');
                fileName = Path.GetFileName(fileName);
                MemoryStream ms = new MemoryStream();
                Stream s = file.OpenReadStream();
                s.CopyTo(ms);
                byte[] data = ms.ToArray();
                s.Close();
                ms.Close();

                UploadedFile primaryObj = new UploadedFile();
                primaryObj.FileName = fileName;
                primaryObj.ContentType = file.ContentType;
                primaryObj.Size = file.Length;
                primaryObj.TimeStamp = DateTime.Now;
                primaryObj.FileContent = data;

                IUploadedFile backupObj = primaryObj.Clone();

                //Upload Files To Be Define
            }
        }
    }
}
