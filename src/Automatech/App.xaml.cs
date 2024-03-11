using Automatech.Views;
using Prism.Ioc;
using Prism.Regions;
using Prism.Unity;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Automatech
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<MainWindow>();
        }
    }

}
