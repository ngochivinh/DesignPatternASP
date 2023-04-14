namespace DesignPatternASP.DesignPattern.Interpreter
{
    public interface IApiCall
    {
        string AssemblyName { get; set; }
        string ClassName { get; set; }
        string MethodName { get; set; }
        List<string> Parameters { get; set; }
        void Interpret(InterpreterContext context);
    }
}
