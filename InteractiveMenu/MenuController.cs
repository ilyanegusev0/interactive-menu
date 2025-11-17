using InteractiveMenu.Items;

namespace InteractiveMenu
{
    internal sealed class MenuController
    {
        // FIELDS:

        private readonly MenuConfiguration _configuration;
        private readonly MenuRenderer _renderer;

        // CONSTRUCTORS:

        public MenuController(MenuConfiguration configuration, MenuRenderer renderer)
        {
            _configuration = configuration;
            _renderer = renderer;
        }

        // METHODS:

        // public

        public object? Run(List<MenuItem> items)
        {
            Console.CursorVisible = false;

            int selectedIndex = items.FindIndex(IsSelectable);
            int startRow = Console.GetCursorPosition().Top;

            while (true)
            {
                _renderer.Draw(items, selectedIndex, startRow);

                ConsoleKeyInfo key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        selectedIndex = Navigate(items, selectedIndex, -1);

                        break;

                    case ConsoleKey.DownArrow:
                        selectedIndex = Navigate(items, selectedIndex, 1);

                        break;

                    case ConsoleKey.Enter:
                        Console.CursorVisible = true;

                        var selectedItem = items[selectedIndex] as OptionItem;
                        if (selectedItem != null)
                        {
                            if (selectedItem.Value != null)
                                return selectedItem.Value;

                            int logicalIndex = items.OfType<OptionItem>().ToList().IndexOf(selectedItem);

                            return logicalIndex;
                        }

                        break;

                    case ConsoleKey.Escape:
                        Console.CursorVisible = true;
                        return null;
                }
            }
        }

        // private 

        private static bool IsSelectable(MenuItem item) => item.IsSelectable;

        private static int Navigate(List<MenuItem> items, int currentIndex, int direction)
        {
            int newIndex = currentIndex;

            do
            {
                newIndex = (newIndex + direction + items.Count) % items.Count;

                if (newIndex == currentIndex)
                    break;
            }
            while (!IsSelectable(items[newIndex]));

            return newIndex;
        }
    }
}