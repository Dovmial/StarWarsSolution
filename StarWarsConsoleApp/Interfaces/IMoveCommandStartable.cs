

using System.Numerics;

namespace StarWarsConsoleApp.Interfaces
{
    public interface IMoveCommandStartable: ICommand
    {
        IUObject Order { get; }
        Vector3 Velocity { get; }
        Queue<ICommand> Commands { get; }
        public IInjectableCommand MoveCommand { get; }
    }
}
