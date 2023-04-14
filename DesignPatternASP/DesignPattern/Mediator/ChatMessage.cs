namespace DesignPatternASP.DesignPattern.Mediator
{
    public class ChatMessage
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Message { get; set; }
        public DateTime SentOn { get; set; }
    }
}
