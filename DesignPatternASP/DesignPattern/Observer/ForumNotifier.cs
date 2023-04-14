namespace DesignPatternASP.DesignPattern.Observer
{
    public class ForumNotifier : IForumNotifier
    {
        private static List<IForumObserver> observers;

        static ForumNotifier() 
        {
            observers = new List<IForumObserver>();
        }

        public void Notify(ForumPost post)
        {
            foreach (IForumObserver observer in observers)
            {
                observer.Update(post);
            }
        }

        public void Subcribe(IForumObserver observer)
        {
            observers.Add(observer);
        }

        public void UnSubcribe(IForumObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
