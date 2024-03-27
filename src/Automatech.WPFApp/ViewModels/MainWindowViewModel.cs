using System;
using System.Windows.Input;
using Automatech.WPFApp.Helper;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Automatech.WPFApp.ViewModels
{
    public class MainWindowViewModel : ObservableObject
    {
        public MainWindowViewModel()
        {
            SubmitCommand = new DelegateCommand(Submit, CanSubmit);
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

        private void Submit()
        {
            Console.WriteLine(Input);
            Input = null;
        }

        private string _Input;

        public string Input
        {
            get => _Input;
            set => SetProperty(ref _Input, value);
        }
        
        public ICommand SubmitCommand { get; set; }
        
    }
}