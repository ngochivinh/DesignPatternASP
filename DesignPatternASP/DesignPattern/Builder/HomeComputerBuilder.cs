namespace DesignPatternASP.DesignPattern.Builder
{
    public class HomeComputerBuilder : IComputerBuilder
    {
        private Computer Computer { get; set; }
        public HomeComputerBuilder() 
        {
            Computer = new Computer();
            Computer.Parts = new List<ComputerPart>();
        }
        public void AddCabinet()
        {
            Computer.Parts.Add(new ComputerPart { UseType = "Home", Part = "Cabinet" });
        }

        public void AddCPU()
        {
            Computer.Parts.Add(new ComputerPart { UseType = "Home", Part = "CPU" });
        }

        public void AddKeyboard()
        {
            Computer.Parts.Add(new ComputerPart { UseType = "Home", Part = "Keyboard" });
        }

        public void AddMonitor()
        {
            Computer.Parts.Add(new ComputerPart { UseType = "Home", Part = "Monitor" });
        }

        public void AddMouse()
        {
            Computer.Parts.Add(new ComputerPart { UseType = "Home", Part = "Mouse" });
        }

        public Computer GetComputer()
        {
            return Computer;
        }
    }
}
