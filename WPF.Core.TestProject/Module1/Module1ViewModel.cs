using Microsoft.Extensions.Configuration;
using WPF.Core.TestProject.Service;

namespace WPF.Core.TestProject.Module1
{
    internal class Module1ViewModel : ViewModel
    {
        public string ExampleText { get; set; }

        public string ConfigurationText { get; set; }

        public Module1ViewModel(IInjectionService injectionService, IConfiguration configuration)
        {
            ExampleText = injectionService.InjectionServiceElement;
            ConfigurationText = configuration.GetValue<string>("ConfigEntry");
        }
    }
}
