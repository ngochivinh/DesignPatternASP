namespace DesignPatternASP.DesignPattern.Command
{
    public class OrderVisitingCards : ICommand
    {
        private EmployeeManager manager;
        public OrderVisitingCards(EmployeeManager manager)
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
