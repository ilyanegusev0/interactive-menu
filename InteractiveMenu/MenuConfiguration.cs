namespace InteractiveMenu
{
    internal sealed class MenuConfiguration
    {
        // SINGLETON:

        public static MenuConfiguration Configuration { get; } = new MenuConfiguration();

        // PROPERTIES:

        public ConsoleColor DefaultColor { get; set; } = ConsoleColor.Gray;
        public ConsoleColor SelectedColor { get; set; } = ConsoleColor.Green;
        public bool IsShowSelector { get; set; } = true;
        public string Selector { get; set; } = " <";

        // CONSTRUCTORS:

        private MenuConfiguration() { }
    }
}