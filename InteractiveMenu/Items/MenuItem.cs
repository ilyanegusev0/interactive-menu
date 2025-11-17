namespace InteractiveMenu.Items
{
    public abstract class MenuItem
    {
        // PROPERTIES:
        public string Text { get; }
        public ConsoleColor Color { get; }
        public bool IsSelectable { get; }

        // CONSTRUCTORS:

        protected MenuItem(string text, ConsoleColor color, bool isSelectable)
        {
            Text = text;
            Color = color;
            IsSelectable = isSelectable;
        }
    }
}