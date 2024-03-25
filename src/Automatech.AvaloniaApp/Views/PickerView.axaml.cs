using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Automatech.AvaloniaApp.Views;

public partial class PickerView : UserControl
{
    public PickerView()
    {
        InitializeComponent();
        this.Cal.BlackoutDates.Add(new CalendarDateRange(DateTime.Now.AddDays(5),DateTime.Now.AddDays(10)) );
    }
}