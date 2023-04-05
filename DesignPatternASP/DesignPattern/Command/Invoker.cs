namespace DesignPatternASP.DesignPattern.Command
{
    public class Invoker
    {
        public List<ICommand> Commands { get; set; } = new List<ICommand>();
        public void Execute()
        {
            try
            {
                foreach (ICommand command in Commands)
                {
                    command.Execute();
                }
            }
            catch
            {
                foreach (ICommand command in Commands)
                {
                    command.Undo();
                }
            }
        }
    }
}
