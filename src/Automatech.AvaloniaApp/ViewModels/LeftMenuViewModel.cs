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
        def.Children.Add(new TreeNode("��ť", typeof(ButtonViewModel)));
        def.Children.Add(new TreeNode("�����", typeof(TextBoxViewModel)));
        def.Children.Add(new TreeNode("�˵�", typeof(MenuViewModel)));
        def.Children.Add(new TreeNode("�б�", typeof(ListViewModel)));
        def.Children.Add(new TreeNode("��ѡ��", typeof(CheckBoxViewModel)));
        def.Children.Add(new TreeNode("����", typeof(ComboBoxViewModel)));
        def.Children.Add(new TreeNode("�����", typeof(GroupBoxViewModel)));
        def.Children.Add(new TreeNode("��ǩ��", typeof(TabViewModel)));
        def.Children.Add(new TreeNode("������", typeof(ProgressBarViewModel)));
        def.Children.Add(new TreeNode("������", typeof(SliderViewModel)));
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