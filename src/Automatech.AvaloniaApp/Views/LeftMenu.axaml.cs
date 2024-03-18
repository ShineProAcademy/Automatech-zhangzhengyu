using Automatech.AvaloniaApp.ViewModels;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Automatech.AvaloniaApp.Views;

public partial class LeftMenu : UserControl
{
    public LeftMenu()
    {
        InitializeComponent();
        this.DataContext = new LeftViewModel();
    }
}