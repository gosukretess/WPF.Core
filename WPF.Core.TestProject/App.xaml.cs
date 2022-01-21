using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using WPF.Core.TestProject.Service;

namespace WPF.Core.TestProject;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs args)
    {
        base.OnStartup(args);

        new ServiceCollectionBuilder()
            .AddMainWindow<MainWindow>()
            .ConfigureServices(services =>
            {
                services.AddTransient<IInjectionService, InjectionService>();
            })
            .AddConfiguration()
            .AddViewModels()
            .Build();

        Ioc.Default.GetService<MainWindow>()!.Show();
    }
}
