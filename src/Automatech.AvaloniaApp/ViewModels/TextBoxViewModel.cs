using System.Collections.ObjectModel;
using System.Linq;

namespace Automatech.AvaloniaApp.ViewModels;

public class TextBoxViewModel : ViewModelBase
{
    public ObservableCollection<string> Source { get; set; }

    public TextBoxViewModel()
    {
        Source = new ObservableCollection<string>
        {
            "张三", "李四", "王五", "赵六"
        };
    }
}