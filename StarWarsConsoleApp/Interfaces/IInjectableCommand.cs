

namespace StarWarsConsoleApp.Interfaces
{
    public interface IInjectableCommand: ICommand
    {
        void Inject(ICommand injectCommand);
    }
}
