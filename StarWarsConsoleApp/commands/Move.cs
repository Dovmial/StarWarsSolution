using StarWarsConsoleApp.Interfaces;

namespace StarWarsConsoleApp.Commands
{
    public class Move
    {
        private IMovable _movableObject;
        public Move(IMovable movableObject)
        {
            _movableObject = movableObject;
        }
        public void Execute()
        {
            _movableObject.Position = _movableObject.Position + _movableObject.Velocity;
        }
    }

}
