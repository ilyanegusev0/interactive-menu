namespace InteractiveMenu.Items
{
    public sealed class EmptyItem : MenuItem
    {
        // PROPERTIES:

        public int Count { get; }

        // CONSTRUCTORS:

        public EmptyItem()
            : base(string.Empty, MenuConfiguration.Configuration.DefaultColor, false)
        {
            Count = 1;
        }

        public EmptyItem(int count)
            : base(string.Empty, MenuConfiguration.Configuration.DefaultColor, false)
        {
            if (count < 1)
                throw new ArgumentOutOfRangeException();

            Count = count;
        }
    }
}