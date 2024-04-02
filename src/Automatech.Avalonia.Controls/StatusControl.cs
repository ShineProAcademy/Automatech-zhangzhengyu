using System;
using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls.Primitives;
using Avalonia.Media;

namespace Automatech.Avalonia.Controls
{
    /// <summary>
    /// 状态控件
    /// </summary>
    public class StatusControl : TemplatedControl
    {
        public ObservableCollection<StatusItem> Items { get; private set; }

        public StatusControl()
        {
            Items = new ObservableCollection<StatusItem>();
            StateProperty.Changed.AddClassHandler<StatusControl>(StatePropertyChanged);

        }
        private void StatePropertyChanged(StatusControl sender, AvaloniaPropertyChangedEventArgs arg)
        {
           
        }

        public static readonly StyledProperty<string> StateProperty = AvaloniaProperty.Register<StatusControl, string>(
            nameof(State));

        public string State
        {
            get => GetValue(StateProperty);
            set => SetValue(StateProperty, value);
        }

        public static readonly StyledProperty<Brush> BrushProperty = AvaloniaProperty.Register<StatusControl, Brush>(
            nameof(Brush));

        public Brush Brush 
        {
            get => GetValue(BrushProperty);
            set => SetValue(BrushProperty, value);
        }

        public static readonly StyledProperty<string> TextProperty = AvaloniaProperty.Register<StatusControl, string>(
            nameof(Text));

        public string Text
        {
            get => GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }
    }

    public class StatusItem
    {
        public string State { get; set; }

        public Brush Brush { get; set; }

        public string Text { get; set; }
    }
}