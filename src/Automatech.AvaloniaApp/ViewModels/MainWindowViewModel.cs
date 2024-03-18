using Automatech.AvaloniaApp.Views;
using ReactiveUI;

namespace Automatech.AvaloniaApp.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase _LeftMenu;
    
    private ViewModelBase _MainConent;

    public ViewModelBase LeftMenu
    {
        get => _LeftMenu;
        private set => this.RaiseAndSetIfChanged(ref _LeftMenu, value);
    }
    
    public ViewModelBase MainConent
    {
        get => _MainConent;
        private set => this.RaiseAndSetIfChanged(ref _MainConent, value);
    }
    
    public MainWindowViewModel()
    {
        LeftMenu = new LeftMenuViewModel();
        MainConent = new CommandViewModel();
    }
}