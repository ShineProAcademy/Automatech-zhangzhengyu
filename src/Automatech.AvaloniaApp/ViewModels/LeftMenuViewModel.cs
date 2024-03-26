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

        TreeNode def = new TreeNode("默认控件", null);
        def.Children.Add(new TreeNode("按钮", typeof(ButtonViewModel)));
        def.Children.Add(new TreeNode("输入框", typeof(TextBoxViewModel)));
        def.Children.Add(new TreeNode("列表", typeof(ListViewModel)));
        def.Children.Add(new TreeNode("日期选择", typeof(PickerViewModel)));
        def.Children.Add(new TreeNode("面板", typeof(PanelViewModel)));
        def.Children.Add(new TreeNode("悬浮框", typeof(FlyoutViewModel)));
        def.Children.Add(new TreeNode("样式Demo", typeof(BindingViewModel)));
        Nodes.Add(def);
    }

    private void RegisterTypes()
    {
        _container.RegisterType(typeof(LeftMenuViewModel), new SingletonLifetimeManager());
        _container.RegisterType(typeof(ButtonViewModel), new SingletonLifetimeManager());
        _container.RegisterType(typeof(ListViewModel), new SingletonLifetimeManager());
        _container.RegisterType(typeof(TextBoxViewModel), new SingletonLifetimeManager());
        _container.RegisterType(typeof(PickerViewModel), new SingletonLifetimeManager());
        _container.RegisterType(typeof(PanelViewModel), new SingletonLifetimeManager());
        _container.RegisterType(typeof(BindingViewModel), new SingletonLifetimeManager());
        _container.RegisterType(typeof(FlyoutViewModel), new SingletonLifetimeManager());
    }
}