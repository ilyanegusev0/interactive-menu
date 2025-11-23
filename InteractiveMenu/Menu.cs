using InteractiveMenu.Items;

namespace InteractiveMenu
{
    public class Menu
    {
        // FIELDS:

        private readonly MenuConfiguration _configuration;
        private readonly MenuRenderer _renderer;
        private readonly MenuController _controller;

        // PROPERTIES:

        public ConsoleColor DefaultColor
        {
            get => _configuration.DefaultColor;
            set => _configuration.DefaultColor = value;
        }
        public ConsoleColor SelectedColor
        {
            get => _configuration.SelectedColor;
            set => _configuration.SelectedColor = value;
        }
        public bool IsShowSelector
        {
            get => _configuration.IsShowSelector;
            set => _configuration.IsShowSelector = value;
        }
        public string Selector
        {
            get => _configuration.Selector;
            set => _configuration.Selector = value;
        }
        public ConsoleKey KeyUp
        {
            get => _configuration.KeyUp;
            set => _configuration.KeyUp = value;
        }
        public ConsoleKey KeyDown
        {
            get => _configuration.KeyDown;
            set => _configuration.KeyDown = value;
        }
        public ConsoleKey KeySelect
        {
            get => _configuration.KeySelect;
            set => _configuration.KeySelect = value;
        }
        public ConsoleKey KeyCancel
        {
            get => _configuration.KeyCancel;
            set => _configuration.KeyCancel = value;
        }

        // CONSTRUCTORS:

        public Menu()
        {
            _configuration = MenuConfiguration.Configuration;
            _renderer = new MenuRenderer(_configuration);
            _controller = new MenuController(_configuration, _renderer);
        }

        // METHODS:

        public object? Show(params IEnumerable<MenuItem>[] lists)
        {
            var merged = new List<MenuItem>();
            foreach (var list in lists)
                merged.AddRange(list);

            return _controller.Run(merged);
        }
    }
}