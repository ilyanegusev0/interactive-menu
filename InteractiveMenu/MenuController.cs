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

                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case var k when k == _configuration.KeyUp:
                        selectedIndex = Navigate(items, selectedIndex, -1);

                        break;

                    case var k when k == _configuration.KeyDown:
                        selectedIndex = Navigate(items, selectedIndex, 1);

                        break;

                    case var k when k == _configuration.KeySelect:
                        Console.CursorVisible = true;

                        var selectedItem = items[selectedIndex];
                        if (selectedItem is OptionItem optionitem)
                        {
                            if (optionitem.Value != null)
                                return optionitem.Value;

                            int logicalIndex = items.OfType<OptionItem>().ToList().IndexOf(optionitem);

                            return logicalIndex;
                        }
                        else if (selectedItem is ActionItem actionItem)
                        {
                            return actionItem.Execute();
                        }

                        break;

                    case var k when k == _configuration.KeyCancel:
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