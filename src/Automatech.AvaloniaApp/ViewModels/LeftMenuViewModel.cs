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
        def.Children.Add(new TreeNode("��ť"){Commad = "button"});
        def.Children.Add(new TreeNode("�˵�"){Commad = "menu"});
        def.Children.Add(new TreeNode("�б�"){Commad = "list"});
        Nodes.Add(def);
        
        // TreeNode custom = new TreeNode("�Զ���ؼ�");
        // custom.Children.Add(new TreeNode("��ť"));
        // custom.Children.Add(new TreeNode("�˵�"));
        // custom.Children.Add(new TreeNode("�б�"));
        //Nodes.Add(custom);
    }

    public void Navigate(TreeNode node)
    {
        
    }
}