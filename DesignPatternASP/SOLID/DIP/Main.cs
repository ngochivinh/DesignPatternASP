namespace DesignPatternASP.SOLID.DIP
{
    public class Main
    {
        public void ChangePassword(string notificationType)
        {
            INotifier notifier = null;
            switch (notificationType)
            {
                case "email":
                    notifier = new EmailNotifier();
                    break;
                case "sms":
                    notifier = new SMSNotifier();
                    break;
            }
            UserManager mgr = new UserManager(notifier);
            mgr.ChangePassword("user1", "oldpwd", "newpwd");
        }
    }
}
