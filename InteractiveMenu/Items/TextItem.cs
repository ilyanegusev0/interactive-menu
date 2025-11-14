namespace InteractiveMenu.Items
{
    public sealed class TextItem : MenuItem
    {
        // CONSTRUCTORS:

        public TextItem(string text)
            : base(text, MenuConfiguration.Configuration.DefaultColor, false) { }

        public TextItem(string text, ConsoleColor color)
            : base(text, color, false) { }
    }
}