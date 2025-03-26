using StarWarsConsoleApp.Interfaces;

namespace StarWarsConsoleApp.Commands
{
    public class MoveCommand: ICommand
    {
        private IMovable _movableObject;
        public MoveCommand(IMovable movableObject)
        {
            _movableObject = movableObject;
        }
        public void Execute()
        {
            _movableObject.Position = _movableObject.Position + _movableObject.Velocity;
        }
    }

}
