namespace DesignPatternASP.DesignPattern.Mediator
{
    public class Participant : IParticipant
    {
        private IChatRoom chatroom;
        public string Name { get; set; }
        public Participant(string name, IChatRoom chatroom)
        {
            this.Name = name;
            this.chatroom = chatroom;
        }

        public List<ChatMessage> GetChatHistory()
        {
            throw new NotImplementedException();
        }

        public void Receive(string from, string message)
        {
            throw new NotImplementedException();
        }

        public void Send(string to, string message)
        {
            chatroom.Send(this.Name, to, message);
        }
    }
}
