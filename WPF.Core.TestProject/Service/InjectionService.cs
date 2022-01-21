namespace WPF.Core.TestProject.Service;

internal class InjectionService : IInjectionService
{
    public string InjectionServiceElement => "Example text from injected service";
}

internal interface IInjectionService
{
    public string InjectionServiceElement { get; }
}