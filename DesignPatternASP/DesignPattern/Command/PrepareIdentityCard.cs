namespace DesignPatternASP.DesignPattern.Command
{
    public class PrepareIdentityCard:ICommand
    {
        private EmployeeManager manager;
        public PrepareIdentityCard(EmployeeManager manager)
        {
            this.manager = manager;
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
