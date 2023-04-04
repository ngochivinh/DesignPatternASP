namespace DesignPatternASP.DesignPattern.Composite
{
    public interface IMenuComponent
    {
        string Text { get; set; }
        string NavigateUrl { get; set; }
        List<IMenuComponent> Children { get; set; } 
    }
}
