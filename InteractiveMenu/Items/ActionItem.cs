namespace InteractiveMenu.Items
{
    public sealed class ActionItem : MenuItem
    {
        // FIELDS:

        private readonly Func<object?> _action;

        // CONSTRUCTORS:

        public ActionItem(string text, Action action, ConsoleColor color)
            : base(text, color, true)
        {
            _action = () => { action(); return null; };
        }
        public ActionItem(string text, Action action)
            : this(text, action, MenuConfiguration.Configuration.DefaultColor) { }

        public ActionItem(string text, Func<object?> action, ConsoleColor color)
            : base(text, color, true)
        {
            _action = action;
        }

        public ActionItem(string text, Func<object?> action)
            : this(text, action, MenuConfiguration.Configuration.DefaultColor) { }

        // METHODS:

        public object? Execute() => _action();
    }
}