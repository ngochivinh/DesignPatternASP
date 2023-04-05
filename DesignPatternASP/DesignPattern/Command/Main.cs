namespace DesignPatternASP.DesignPattern.Command
{
    public class Main
    {
        public void ProcessEmployee(int employeeId)
        {
            EmployeeManager employeeManager = new EmployeeManager(employeeId);
            Invoker invoker = new Invoker();

            ICommand command = null;

            command = new CreateEmailAccount(employeeManager);
            invoker.Commands.Add(command);

            command = new OrderVisitingCards(employeeManager);
            invoker.Commands.Add(command);

            command = new PrepareIdentityCard(employeeManager);
            invoker.Commands.Add(command);

            invoker.Execute();
        }
    }
}
