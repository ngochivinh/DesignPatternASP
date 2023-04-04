using System.Drawing;

namespace DesignPatternASP.DesignPattern.Decorator
{
    public class Photo:IPhoto
    {
        private string fileName;

        public Photo(string filename)
        {
            this.fileName = filename;
        }

        public Bitmap GetPhoto()
        {
            Bitmap bmp = (Bitmap)Image.FromFile(fileName);
            return bmp;
        }
    }
}
