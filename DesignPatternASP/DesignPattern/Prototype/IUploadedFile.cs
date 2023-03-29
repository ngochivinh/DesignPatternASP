namespace DesignPatternASP.DesignPattern.Prototype
{
    public interface IUploadedFile
    {
        string FileName { get; set; }
        long Size { get; set; }
        string ContentType { get; set; }
        DateTime TimeStamp { get; set; }
        byte[] FileContent { get; set; }

        IUploadedFile Clone();
    }
}
