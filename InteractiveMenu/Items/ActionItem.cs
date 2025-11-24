namespace InteractiveMenu.Items
{
    public sealed class ActionItem : MenuItem
    {
        // FIELDS:

        private readonly Action _action;

        // PROPERTIES:

        public Action Action => _action;

        // CONSTRUCTORS:

        public ActionItem(string text, Action action, ConsoleColor color) : base(text, color, true)
        {
            _action = action;
        }

        public ActionItem(string text, Action action) : this(text, action, MenuConfiguration.Configuration.DefaultColor) { }

        // METHODS:

        public void Execute() => _action();
    }
}
