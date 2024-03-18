using System;
using System.Collections.Generic;
using Automatech.AvaloniaApp.Models;
using Automatech.AvaloniaApp.Services;
using ReactiveUI;

namespace Automatech.AvaloniaApp.ViewModels;

public class LeftMenuViewModel : ViewModelBase
{
    public IList<TreeNode> Nodes { get; set; }

    public LeftMenuViewModel()
    {
        Nodes = new List<TreeNode>();
        //Nodes = MenuManager.Load();

        TreeNode def = new TreeNode("Ursa");
        def.Children.Add(new TreeNode("按钮"){Commad = "button"});
        def.Children.Add(new TreeNode("菜单"){Commad = "menu"});
        def.Children.Add(new TreeNode("列表"){Commad = "list"});
        Nodes.Add(def);
        
        // TreeNode custom = new TreeNode("自定义控件");
        // custom.Children.Add(new TreeNode("按钮"));
        // custom.Children.Add(new TreeNode("菜单"));
        // custom.Children.Add(new TreeNode("列表"));
        //Nodes.Add(custom);
    }

    public void Navigate(TreeNode node)
    {
        
    }
}