using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using System.Drawing.Imaging;
using System.Drawing;

namespace DesignPatternASP.DesignPattern.Decorator
{
    public class Main
    {
        public byte[] GetImageOriginal()
        {
            string fileName = ("images/computer.png");
            IPhoto photo = new Photo(fileName);
            Bitmap bmp = photo.GetPhoto();
            MemoryStream stream = new MemoryStream();
            bmp.Save(stream, ImageFormat.Png);
            byte[] data = stream.ToArray();
            stream.Close();
            return data;
        }

        public byte[] GetImageWatermarked()
        {
            string fileName = ("images/computer.png");
            IPhoto photo = new Photo(fileName);
            WatermarkDecorator decorator = new WatermarkDecorator(photo, "Copyright (C) 2015.");
            Bitmap bmp = decorator.GetPhoto();
            MemoryStream stream = new MemoryStream();
            bmp.Save(stream, ImageFormat.Png);
            byte[] data = stream.ToArray();
            stream.Close();
            return data;
        }
    }
}
