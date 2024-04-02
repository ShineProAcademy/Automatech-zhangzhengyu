using System.Globalization;
using Automatech.AvaloniaApp.ViewModels;
using AutoMatech.DataRepository.Implements;
using AutoMatech.DataRepository.Interface;
using AutoMatech.DataRepository.Models;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Unity;

namespace Automatech.AvaloniaApp
{
    public partial class App : Application
    {
        private IUnityContainer Container;
        
        public App()
        {
            Container = new UnityContainer();
        }
        
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
            ConfigureServices();
        }

        public override void OnFrameworkInitializationCompleted()
        {
            Assets.localization.Resources.Culture = new CultureInfo("en-US");
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                Container.RegisterType<MainWindowViewModel>();
                desktop.MainWindow = new MainWindow()
                {
                    DataContext = Container.Resolve<MainWindowViewModel>()
                };
            }

            base.OnFrameworkInitializationCompleted();
        }

        /// <summary>
        /// 配置服务
        /// </summary>
        private void ConfigureServices()
        {
            //Container.RegisterInstance<IUnityContainer>(Container);
            Container.RegisterType<IDataRepository<Student, int>,StudentRepository>();
        }
        
        /// <summary>
        ///  判断当前使否是生成环境
        /// </summary>
        /// <returns></returns>
        private bool IsProduction()
        {
#if DEBUG
            return false;
#else 
            return true;
#endif
        }
    }
}