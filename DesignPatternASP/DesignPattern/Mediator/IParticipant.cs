namespace DesignPatternASP.DesignPattern.Mediator
{
    public interface IParticipant
    {
        string Name { get; set; }
        void Send(string to, string message);
        void Receive(string from, string message);
        List<ChatMessage> GetChatHistory();
    }
}
