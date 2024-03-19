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
        def.Children.Add(new TreeNode("��ť", typeof(ButtonViewModel)));
        def.Children.Add(new TreeNode("�����", typeof(TextBoxViewModel)));
        def.Children.Add(new TreeNode("�˵�", typeof(MenuViewModel)));
        def.Children.Add(new TreeNode("�б�", typeof(ListViewModel)));
        Nodes.Add(def);
    }
}