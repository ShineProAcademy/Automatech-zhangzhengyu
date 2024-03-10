using Automatech.Controls.Data;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Automatech.Controls
{
    /// <summary>
    /// 状态控件
    /// </summary>
    public class StatusControl: Control
    {

        public StatusControl()
        {
            Items = new ObservableCollection<StatusItem>();
            this.Loaded += Load;
        }

        private void Load(object sender, RoutedEventArgs e)
        {
            StatusItem item = Items.FirstOrDefault(m => m.Status == Status);
            if (item != null)
            {
                Brush = item.Brush;
                Text = item.Text;
            }
        }

        public Status Status
        {
            get { return (Status)GetValue(StatusProperty); }
            set { SetValue(StatusProperty, value); }
        }

        public static readonly DependencyProperty StatusProperty =
            DependencyProperty.Register("Status", typeof(Status), typeof(StatusControl), new PropertyMetadata(Status.None, StatusPropertyChanged));

        private static void StatusPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            StatusControl control = (StatusControl)d;
            StatusItem item = control.Items.FirstOrDefault(m => m.Status == (Status)e.NewValue);
            if (item != null)
            {
                control.Brush = item.Brush;
                control.Text = item.Text;
            }
        }

        public Brush Brush
        {
            get { return (Brush)GetValue(BrushProperty); }
            set { SetValue(BrushProperty, value); }
        }

        public static readonly DependencyProperty BrushProperty =
            DependencyProperty.Register("Brush", typeof(Brush), typeof(StatusControl), new PropertyMetadata(Brushes.Transparent));


        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(StatusControl), new PropertyMetadata(null));

        public ObservableCollection<StatusItem> Items { get; set; }
    }

    public class StatusItem
    {
        public Status Status { get; set; }

        public Brush Brush { get; set; }

        public string Text { get; set; }
    }
}