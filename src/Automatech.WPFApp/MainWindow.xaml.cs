using System;
using System.Reactive;
using System.Reactive.Subjects;
using System.Windows;
using Console = System.Console;

namespace Automatech.WPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Subject<string> _subject = new Subject<string>();
        
        public MainWindow()
        {
            InitializeComponent();
            _subject.Subscribe(value => Console.WriteLine("fds"));
        }
        
    }

    
}