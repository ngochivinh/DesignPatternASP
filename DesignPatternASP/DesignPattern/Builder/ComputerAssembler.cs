namespace DesignPatternASP.DesignPattern.Builder
{
    public class ComputerAssembler
    {
        private IComputerBuilder _computerBuilder;

        public ComputerAssembler(IComputerBuilder computerBuilder)
        {
            _computerBuilder = computerBuilder;
        }

        public Computer AssembleComputer()
        {
            _computerBuilder.AddCPU();
            _computerBuilder.AddMonitor();
            _computerBuilder.AddCabinet();
            _computerBuilder.AddKeyboard();
            _computerBuilder.AddMouse();

            return _computerBuilder.GetComputer();
        }
    }
}
