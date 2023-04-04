using System.Drawing;

namespace DesignPatternASP.DesignPattern.Decorator
{
    public abstract class DecoratorBase : IPhoto
    {
        private IPhoto _photo;
        public DecoratorBase(IPhoto photo)
        {
            _photo = photo;
        }

        public virtual Bitmap GetPhoto()
        {
            return _photo.GetPhoto();
        }
    }
}
