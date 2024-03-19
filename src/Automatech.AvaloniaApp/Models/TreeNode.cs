using System;
using System.Collections.Generic;
using System.Windows.Input;
using Automatech.AvaloniaApp.ViewModels;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

namespace Automatech.AvaloniaApp.Models
{
    public class TreeNode
    {
        public string Header { get; set; }

        public Type CommandParameter { get; private set; }

        public bool IsSelected { get; set; }
        public ICommand Command { get; set; }

        public TreeNode(string header, Type commandParameter) 
        {
            this.Header = header;
            this.CommandParameter = commandParameter;
            this.Command = new RelayCommand(Navigate);
            this.Children = new List<TreeNode>();
        }

        private void Navigate()
        {
            WeakReferenceMessenger.Default.Send<TreeNode>(this);
        }

        public IList<TreeNode> Children { get; private set; }
    }
}
