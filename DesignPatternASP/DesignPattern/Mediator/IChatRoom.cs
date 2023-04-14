namespace DesignPatternASP.DesignPattern.Mediator
{
    public interface IChatRoom
    {
        void Login(IParticipant participant);
        void Logout(IParticipant participant);
        void Send(string from, string to, string message);
    }
}
