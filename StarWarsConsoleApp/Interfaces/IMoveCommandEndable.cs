

namespace StarWarsConsoleApp.Interfaces
{
    public interface IMoveCommandEndable: ICommand
    {
        ICommand MoveCommand { get; }
        IUObject moveObject { get; }
        Queue<ICommand> Commands { get; }
    }
}
