using System.Drawing;

namespace DesignPatternASP.DesignPattern.Decorator
{
    public class WatermarkDecorator:DecoratorBase
    {
        private string waterMarkText;
        public WatermarkDecorator(IPhoto photo, string watermark):base(photo)
        {
            this.waterMarkText = watermark;
        }

        public override Bitmap GetPhoto()
        {
            Bitmap bmp = base.GetPhoto();
            Graphics g = Graphics.FromImage(bmp);
            Font font = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Pixel);
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            float x = (float)bmp.Width / 2;
            float y = (float)bmp.Height / 2;
            g.DrawString(waterMarkText, font, Brushes.Black, x, y, sf);
            g.Save();
            return bmp;
        }
    }
}
