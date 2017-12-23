using System;
using System.Windows;
using Ninject;
using NugetGenerator.Core;

namespace NugetGenerator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IKernel _container;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ConfigureConainer();
            ConfigureWindowObjects();
            Current.MainWindow.Show();
        }

        private void ConfigureConainer()
        {
            _container = new StandardKernel();
            _container.Bind<IStringValidator>().To<StringValidator>().InTransientScope();
            _container.Bind<MainWindow>().ToSelf();
        }

        private void ConfigureWindowObjects()
        {
            Current.MainWindow = _container.Get<MainWindow>();
            Current.MainWindow.Title = "DoxTek Nuget Package Generator";
        }
    }
}
