namespace DesignPatternASP.DesignPattern.Observer
{
    public interface IForumNotifier
    {
        void Subcribe(IForumObserver observer);
        void UnSubcribe(IForumObserver observer);
        void Notify(ForumPost post);
    }
}
