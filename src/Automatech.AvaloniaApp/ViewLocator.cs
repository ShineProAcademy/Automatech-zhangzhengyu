using Avalonia.Controls;
using Avalonia.Controls.Templates;

namespace Automatech.AvaloniaApp;

public class ViewLocator : IDataTemplate
{
    public Control? Build(object? param)
    {
        return new TextBlock() { Text = "test" };
    }

    public bool Match(object? data)
    {
        return true;
    }
}