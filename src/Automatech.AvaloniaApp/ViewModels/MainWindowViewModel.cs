using System;
using Automatech.AvaloniaApp.Models;
using Avalonia.ReactiveUI;
using CommunityToolkit.Mvvm.Messaging;
using Unity;

namespace Automatech.AvaloniaApp.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private IUnityContainer _container;
    
    private ViewModelBase _LeftMenu;
    
    private ViewModelBase _MainContent;

    public ViewModelBase LeftMenu
    {
        get => _LeftMenu;
        private set => this.SetProperty(ref _LeftMenu, value);
    }
    
    public ViewModelBase MainContent
    {
        get => _MainContent;
        private set => this.SetProperty(ref _MainContent, value);
    }
    
    public MainWindowViewModel(IUnityContainer container)
    {
        this._container = container;
        this.LeftMenu = new LeftMenuViewModel();
        this.MainContent = new TextBoxViewModel();
        
        WeakReferenceMessenger.Default.Register<TreeNode>(this, Navigation);
    }

    private void Navigation(object recipient, TreeNode message)
    {
        if (message is null)
        {
            return;
        }

        if (message.CommandParameter.IsSubclassOf(typeof(ViewModelBase)))
        {
            MainContent = (ViewModelBase)_container.Resolve(message.CommandParameter);
        }
        else
        {
            return;
        }
    }
}