namespace DesignPatternASP.DesignPattern.Composite
{
    public class MenuItem : IMenuComponent
    {
        public string Text { get; set; }
        public string NavigateUrl { get; set; }
        public List<IMenuComponent> Children { get; set; }
    }
}
