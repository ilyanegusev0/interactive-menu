namespace InteractiveMenu.Items
{
    public sealed class OptionItem : MenuItem
    {
        // PROPERTIES:

        public object? Value { get; }

        // CONSTRUCTORS:

        public OptionItem(string text, object? value, ConsoleColor color)
            : base(text, color, true)
        {
            Value = value;
        }

        public OptionItem(string text)
            : this(text, null, MenuConfiguration.Configuration.DefaultColor) { }
        public OptionItem(string text, ConsoleColor color)
            : this(text, null, color) { }
        public OptionItem(string text, object value)
            : this(text, value, MenuConfiguration.Configuration.DefaultColor) { }

    }
}