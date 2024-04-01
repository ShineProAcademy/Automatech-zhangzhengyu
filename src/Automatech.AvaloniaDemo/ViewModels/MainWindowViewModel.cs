using System.Collections;
using System.Collections.Generic;
using System.Security.AccessControl;
using Metsys.Bson;

namespace Automatech.AvaloniaDemo.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
#pragma warning disable CA1822 // Mark members as static
        public string Greeting => "Welcome to Avalonia!";
#pragma warning restore CA1822 // Mark members as static

        public IList<DataItem> Sources { get; set; }
        
        public MainWindowViewModel()
        {
            Sources = new List<DataItem>();

            DataItem item1 = new DataItem()
            {
                Header = "输入端口",
                items = new List<DataItem>()
                {
                    new DataItem() { Header = "输入端口1" },
                    new DataItem() { Header = "输入端口1" },
                    new DataItem() { Header = "输入端口1" },
                    new DataItem() { Header = "输入端口1" },
                }
            };
            
            DataItem item2 = new DataItem()
            {
                Header = "输出端口",
                items = new List<DataItem>()
                {
                    new DataItem() { Header = "输出端口1" },
                    new DataItem() { Header = "输出端口1" },
                    new DataItem() { Header = "输出端口1" },
                    new DataItem() { Header = "输出端口1" },
                }
            };
            Sources.Add(item1);
            Sources.Add(item2);
        }
        
        
    }

    public class DataItem
    {
        public string Header { get; set; }
        
        public IList<DataItem> items { get; set; }
    }
}
