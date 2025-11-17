## Quick start:

```
Menu menu = new Menu();

List<MenuItem> items = new List<MenuItem>()
{
    new TextItem("Header", ConsoleColor.Red),
    new EmptyItem(2),
    new OptionItem("Start"), // 0 by default
    new OptionItem("Settings", "settings"),
    new EmptyItem(),
    new OptionItem("Exit", -1)
};

object result = menu.Show(items);

switch(result)
{
    case 0:
        break;

    case "settings":
        break;

    case -1:
        break;
}
```

Restaurant restaurant = new Restaurant();

## Methods:

- `Show(List<MenuItem> items)` - displays the interactive menu and returns the selected result.

## Items:

-   **EmptyItem** with 2 overloads:

    -   `EmptyItem()` - adds blank item with 1 spacing line.
    -   `EmptyItem(int count)` - adds blank item with specified number of spacing lines.

-   **TextItem** with 2 overloads:

    -   `TextItem(string text)` - adds static text item.
    -   `TextItem(string text, ConsoleColor color)` - adds static text item custom color.

-   **OptionItem** with 4 overloads:
    -   `OptionItem(string text)` - adds selectable item with text.
    -   `OptionItem(string text, ConsoleColor color)` - adds selectable item text and custom color.
    -   `OptionItem(string text, object value)` - adds selectable item with text and an optional value.
    -   `OptionItem(string text, object? value, ConsoleColor color)` - adds selectable item with text, color and optional
        value.
        
## Configuration options:

- `DefaultColor` - text color for non-selected items.
- `SelectedColor` - highlight color for selected items.
- `IsShowSelector` - toggle selector visibility.
- `Selector` - customize selector symbol.