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
        }
        
        public static readonly StyledProperty<string> StateProperty = AvaloniaProperty.Register<StatusControl, string>(
            "State");

        public string State
        {
            get => GetValue(StateProperty);
            set => SetValue(StateProperty, value);
        }

        public static readonly StyledProperty<Brush> BrushProperty = AvaloniaProperty.Register<StatusControl, Brush>(
            "Brush");

        public Brush Brush 
        {
            get => GetValue(BrushProperty);
            set => SetValue(BrushProperty, value);
        }

        public static readonly StyledProperty<string> TextProperty = AvaloniaProperty.Register<StatusControl, string>(
            "Text");

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