using System.Windows.Controls;
using Microsoft.Toolkit.Mvvm.DependencyInjection;

namespace WPF.Core.TestProject.Module1;

public partial class Module1View : UserControl
{
    public Module1View()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<Module1ViewModel>();
    }
}