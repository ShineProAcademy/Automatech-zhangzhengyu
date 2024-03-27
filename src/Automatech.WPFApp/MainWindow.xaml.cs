using System;
using System.Reactive;
using System.Reactive.Subjects;
using System.Windows;
using Automatech.WPFApp.ViewModels;
using Console = System.Console;

namespace Automatech.WPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel();

        }
    }
}