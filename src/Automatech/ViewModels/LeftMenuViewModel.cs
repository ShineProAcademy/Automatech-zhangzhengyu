using Automatech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatech.ViewModels
{
    public class LeftMenuViewModel
    {
        public IList<TreeNode> DataSource { get; set; }

        public LeftMenuViewModel()
        {
            DataSource = new List<TreeNode>();

            TreeNode example = new TreeNode("样板");
            example.Children.Add(new TreeNode("样板1"));
            example.Children.Add(new TreeNode("样板2"));
            example.Children.Add(new TreeNode("样板3"));

            TreeNode controls = new TreeNode("控件");
            controls.Children.Add(new TreeNode("控件1"));
            controls.Children.Add(new TreeNode("控件2"));
            controls.Children.Add(new TreeNode("控件3"));

            DataSource.Add(example);
            DataSource.Add(controls);
        }
    }
}
