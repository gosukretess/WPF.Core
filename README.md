# WPF.Core ![Nuget](https://img.shields.io/nuget/v/WPF.Core)
A simple .NET library enabling MVVM, DI and appsettings.conf in WPF projects
Uses Microsoft.Toolkit.Mvvm that lacks official documentation for WPF applications. This library aims to make creating simple WPF applications easier and faster.

## Features
- Introduces MVVM pattern to .NET5/6 WPF applications
- Enables dependency injection from Microsoft.Extensions.DependencyInjection
- Introduces appsettings.conf configuration file known from ASP.NET Core projects

## Installation
Download [package from nuget repository](https://www.nuget.org/packages/WPF.Core/):
```
Install-Package WPF.Core
```
or
```
dotnet add package WPF.Core
```

## Getting started
1. All view model classes should inherit 'ViewModel' class:
```
internal class Module1ViewModel : ViewModel {}
```
2. View xaml.cs files should set context to correct view model class:
```
DataContext = Ioc.Default.GetService<Module1ViewModel>();
```
3. Configure App.xaml.cs

```csharp
    protected override void OnStartup(StartupEventArgs args)
    {
        base.OnStartup(args);

        new ServiceCollectionBuilder()
            .AddMainWindow<MainWindow>() // class of main window
            .ConfigureServices(services =>
            {
                services.AddTransient<IInjectionService, InjectionService>(); // services to register, other than view models
            })
            .AddConfiguration() // add support for appsettings.json file
            .AddViewModels() // registers all classes inheriting ViewModel class
            .Build();

        Ioc.Default.GetService<MainWindow>()!.Show(); // display main program window
    }
```
If you register and show main window using the above code, you should remove following line from App.xaml file `StartupUri="MainWindow.xaml"`
