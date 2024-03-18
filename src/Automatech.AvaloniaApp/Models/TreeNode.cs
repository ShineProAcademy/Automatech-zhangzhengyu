using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Automatech.AvaloniaApp.Models
{
    public class TreeNode
    {
        public string Header { get; set; } 

        public string Commad { get; set; }

        public TreeNode(string header) 
        {
            Header = header;
            Children = new List<TreeNode>();
        }

        public IList<TreeNode> Children { get; private set; }
    }
}
