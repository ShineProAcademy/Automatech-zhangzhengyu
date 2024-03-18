using System;
using System.Collections.Generic;
using Automatech.AvaloniaApp.Models;
using Automatech.AvaloniaApp.Services;
using ReactiveUI;

namespace Automatech.AvaloniaApp.ViewModels;

public class LeftViewModel
{
    public IList<TreeNode> Nodes { get; set; }

    public LeftViewModel()
    {
        Nodes = new List<TreeNode>();
        Nodes = MenuManager.Load();
    }
}