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

        TreeNode def = new TreeNode("Ĭ�Ͽؼ�", null);
        def.Children.Add(new TreeNode("��ť", typeof(ButtonViewModel)));
        def.Children.Add(new TreeNode("�����", typeof(TextBoxViewModel)));
        def.Children.Add(new TreeNode("�б�", typeof(ListViewModel)));
        def.Children.Add(new TreeNode("����ѡ��", typeof(PickerViewModel)));
        def.Children.Add(new TreeNode("���", typeof(PanelViewModel)));
        def.Children.Add(new TreeNode("������", typeof(FlyoutViewModel)));
        def.Children.Add(new TreeNode("��ʽDemo", typeof(BindingViewModel)));
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