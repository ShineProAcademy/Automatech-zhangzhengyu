using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Automatech.AvaloniaApp.Models;
using Unity;
using Unity.Lifetime;

namespace Automatech.AvaloniaApp.ViewModels;

public class LeftMenuViewModel : ViewModelBase
{
    private IUnityContainer _container;
    public ObservableCollection<TreeNode> Nodes { get; set; }
    public LeftMenuViewModel(IUnityContainer container)
    {
        this._container = container;
        Nodes = new ObservableCollection<TreeNode>();
        //Nodes = MenuManager.Load();
        RegisterTypes();

        TreeNode def = new TreeNode("Ursa", null);
        def.Children.Add(new TreeNode("按钮", typeof(ButtonViewModel)));
        def.Children.Add(new TreeNode("输入框", typeof(TextBoxViewModel)));
        def.Children.Add(new TreeNode("菜单", typeof(MenuViewModel)));
        def.Children.Add(new TreeNode("列表", typeof(ListViewModel)));
        def.Children.Add(new TreeNode("勾选项", typeof(CheckBoxViewModel)));
        def.Children.Add(new TreeNode("下拉", typeof(ComboBoxViewModel)));
        def.Children.Add(new TreeNode("分组框", typeof(GroupBoxViewModel)));
        def.Children.Add(new TreeNode("标签项", typeof(TabViewModel)));
        def.Children.Add(new TreeNode("进度条", typeof(ProgressBarViewModel)));
        def.Children.Add(new TreeNode("滑动条", typeof(SliderViewModel)));
        Nodes.Add(def);
    }

    private void RegisterTypes()
    {
        _container.RegisterType(typeof(LeftMenuViewModel), new SingletonLifetimeManager());
        _container.RegisterType(typeof(ButtonViewModel), new SingletonLifetimeManager());
        _container.RegisterType(typeof(CheckBoxViewModel), new SingletonLifetimeManager());
        _container.RegisterType(typeof(ComboBoxViewModel), new SingletonLifetimeManager());
        _container.RegisterType(typeof(MenuViewModel), new SingletonLifetimeManager());
        _container.RegisterType(typeof(ListViewModel), new SingletonLifetimeManager());
        _container.RegisterType(typeof(TextBoxViewModel), new SingletonLifetimeManager());
        _container.RegisterType(typeof(GroupBoxViewModel), new SingletonLifetimeManager());
        _container.RegisterType(typeof(TabViewModel), new SingletonLifetimeManager());
        _container.RegisterType(typeof(ProgressBarViewModel), new SingletonLifetimeManager());
        _container.RegisterType(typeof(SliderViewModel), new SingletonLifetimeManager());
    }
}