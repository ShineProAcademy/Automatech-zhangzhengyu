using Automatech.AvaloniaApp.ViewModels;
using AutoMatech.DataRepository.Implements;
using AutoMatech.DataRepository.Interface;
using AutoMatech.DataRepository.Models;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Live.Avalonia;
using Unity;
using Unity.Lifetime;

namespace Automatech.AvaloniaApp
{
    /// <summary>
    /// 实现ILiveView接口支持热重载
    /// </summary>
    public partial class App : Application, ILiveView
    {
        private UnityContainer Container;
        
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

        public object CreateView(Window window) => new TextBlock() { Text = "hello world" };

        /// <summary>
        /// 配置服务
        /// </summary>
        private void ConfigureServices()
        {
            Container.RegisterInstance<IUnityContainer>(Container);
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