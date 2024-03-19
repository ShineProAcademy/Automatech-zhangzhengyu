using System.Collections.ObjectModel;
using Automatech.AvaloniaApp.Models;

namespace Automatech.AvaloniaApp.ViewModels;

public class LeftMenuViewModel : ViewModelBase
{
    public ObservableCollection<TreeNode> Nodes { get; set; }
    public LeftMenuViewModel()
    {
        Nodes = new ObservableCollection<TreeNode>();
        //Nodes = MenuManager.Load();

        TreeNode def = new TreeNode("Ursa", null);
        def.Children.Add(new TreeNode("按钮", typeof(ButtonViewModel)));
        def.Children.Add(new TreeNode("输入框", typeof(TextBoxViewModel)));
        def.Children.Add(new TreeNode("菜单", typeof(MenuViewModel)));
        def.Children.Add(new TreeNode("列表", typeof(ListViewModel)));
        Nodes.Add(def);
    }
}