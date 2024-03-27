using System;
using System.Data;
using System.Windows.Input;

namespace Automatech.AvaloniaApp.Services;

public class DelegateCommand : ICommand
{
    private readonly Action _execute;
    private readonly Func<bool> _canExecute;
 
    public DelegateCommand(Action execute, Func<bool> canExecute)
    {
        _execute = execute ?? throw new ArgumentNullException(nameof(execute));
        _canExecute = canExecute ?? (() => true);
    }
    
    public bool CanExecute(object? parameter)
    {
        return _canExecute();
    }

    public void Execute(object? parameter)
    {
        _execute();
    }

    public event EventHandler CanExecuteChanged
    {
        add{ }
        remove { }
    }

}