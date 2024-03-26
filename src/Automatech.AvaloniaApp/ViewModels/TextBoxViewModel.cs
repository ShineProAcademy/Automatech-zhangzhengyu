using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Automatech.AvaloniaApp.ViewModels;

public class TextBoxViewModel : ViewModelBase
{
    public ObservableCollection<string> Source { get; set; }

    public TextBoxViewModel()
    {
        SubmitCommand = new RelayCommand(Submit, CanSubmit);
        Source = new ObservableCollection<string>
        {
            "张三", "李四", "王五", "赵六"
        };

        Age = 10;
    }

    private void Submit()
    {
       Console.WriteLine(Input);
       Input = null;
    }

    private bool CanSubmit()
    {
        if (string.IsNullOrWhiteSpace(Input))
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    private int _Age;
    public int Age
    {
        get => _Age;
        set => SetProperty(ref _Age, value);
    }

    private string _Input;

    public string Input
    {
        get => _Input;
        set => SetProperty(ref _Input, value);
    }
   
    public ICommand SubmitCommand { get; set; }
    
}