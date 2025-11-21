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
        public ConsoleKey KeyUp { get; set; } = ConsoleKey.UpArrow;
        public ConsoleKey KeyDown { get; set; } = ConsoleKey.DownArrow;
        public ConsoleKey KeySelect { get; set; } = ConsoleKey.Enter;
        public ConsoleKey KeyCancel { get; set; } = ConsoleKey.Escape;

        // CONSTRUCTORS:

        private MenuConfiguration() { }
    }
}