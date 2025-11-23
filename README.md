## Quick start:

```csharp
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

## Methods:

- `Show()` - displays the menu and returns the selected result.
  >`Show(params IEnumerable<MenuItem> lists)` - accepts one or more collections of `MenuItem`.\
  >`Show(params MenuItem[] items)` - accepts multiple `MenuItem` objects directly.

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

- `DefaultColor` - text color for non-selected items. (`ConsoleColor.Gray` by default)
- `SelectedColor` - highlight color for selected items. (`ConsoleColor.Green` by default)
- `IsShowSelector` - toggle selector visibility. (`true` by default)
- `Selector` - customize selector symbol. (`" <"` by default)
- `KeyUp` - key used to move selection up. (`ConsoleKey.UpArrow` by default)
- `KeyDown` - key used to move selection down. (`ConsoleKey.DownArrow` by default)
- `KeySelect` - key used to select the current item. (`ConsoleKey.Enter` by default)
- `KeyCancel` - key used to cancel or exit the meny. (`ConsoleKey.Escape` by default)