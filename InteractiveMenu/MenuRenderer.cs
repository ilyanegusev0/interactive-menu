using InteractiveMenu.Items;

namespace InteractiveMenu
{
    internal sealed class MenuRenderer
    {
        // FIELDS:

        private readonly MenuConfiguration _configuration;

        // CONSTRUCTORS:

        public MenuRenderer(MenuConfiguration configuration)
        {
            _configuration = configuration;
        }

        // METHODS:

        public void Draw(List<MenuItem> items, int selectedIndex, int startRow)
        {
            Console.SetCursorPosition(0, startRow);

            for (int i = 0; i < items.Count; i++)
            {
                MenuItem item = items[i];

                if (item.IsSelectable && i == selectedIndex)
                    Console.ForegroundColor = _configuration.SelectedColor;
                else
                    Console.ForegroundColor = item.Color;

                if (item is EmptyItem emptyItem)
                {
                    for (int j = 0; j < emptyItem.Count; j++)
                        Console.WriteLine(string.Empty.PadRight(Console.WindowWidth));

                    continue;
                }

                if (_configuration.IsShowSelector && item.IsSelectable && i == selectedIndex)
                    Console.WriteLine($"{item.Text}{_configuration.Selector}".PadRight(Console.WindowWidth));
                else
                    Console.WriteLine(item.Text.PadRight(Console.WindowWidth));
            }

            Console.ResetColor();
        }
    }
}