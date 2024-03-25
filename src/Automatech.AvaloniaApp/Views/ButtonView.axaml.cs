using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Automatech.AvaloniaApp.Views;

public partial class ButtonView : UserControl
{
    private int count = 0;
    
    public ButtonView()
    {
        InitializeComponent();
    }

    private void Spinner_OnSpin(object? sender, SpinEventArgs e)
    {
       ButtonSpinner buttonSpinner = sender as ButtonSpinner;
       if (e.Direction == SpinDirection.Increase)
       {
           buttonSpinner.Content = count++;
       }
       else if(e.Direction == SpinDirection.Decrease)
       {
           buttonSpinner.Content = count--;
       }
    }
}