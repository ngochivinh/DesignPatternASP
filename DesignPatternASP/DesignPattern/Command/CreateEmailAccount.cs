namespace DesignPatternASP.DesignPattern.Command
{
    public class CreateEmailAccount : ICommand
    {
        private EmployeeManager manager;
        public CreateEmailAccount(EmployeeManager manager)
        {
            this.manager = manager;
        }
        public void Execute()
        {
            manager.CreateEmailAccount();
        }
        public void Undo()
        {
            manager.UndoCreateEmailAccount();
        }
    }
}
