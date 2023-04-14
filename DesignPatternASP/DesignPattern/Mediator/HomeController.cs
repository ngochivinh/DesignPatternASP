using Microsoft.AspNetCore.Mvc;

namespace DesignPatternASP.DesignPattern.Mediator
{
    public class HomeController : Controller
    {
        [HttpPost]
        public void Login([FromBody] ChatUser usr)
        {
            ChatRoom room = new ChatRoom();
            IParticipant participant = new Participant(usr.Name, room);
            room.Login(participant);
        }

        [HttpPost]
        public IActionResult Send([FromBody] ChatMessage message)
        {
            ChatRoom chatRoom = new ChatRoom();
            IParticipant sender = chatRoom.GetParticipant(message.From);
            IParticipant receiver = chatRoom.GetParticipant(message.To);

            if(receiver != null)
            {
                sender.Send(message.To, message.Message);
                return Json(true);
            }
            else
            {
                return Json(false);
            }
        }

        [HttpPost]
        public IActionResult GetHistory([FromBody]ChatUser user)
        {
            ChatRoom room = new ChatRoom();
            IParticipant participant = room.GetParticipant(user.Name);
            if (participant != null)
            {
                return Json(participant.GetChatHistory());
            }

            return Json(string.Empty);
        }
    }
}
