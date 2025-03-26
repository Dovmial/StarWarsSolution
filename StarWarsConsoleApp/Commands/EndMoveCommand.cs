
using StarWarsConsoleApp.Adapters;
using StarWarsConsoleApp.Interfaces;
using System.Numerics;

namespace StarWarsConsoleApp.Commands
{
    public class EndMoveCommand(
        IUObject order,
        IInjectableCommand startMoveCommand,
        Dictionary<string, IUObject> objecs,
        Queue<ICommand> commands
        ) : IMoveCommandEndable
    {
        public Queue<ICommand> Commands { get; init; } = commands;
        public IUObject Order => order;
        public ICommand MoveCommand { get; private set; }

        public IUObject moveObject { get; private set; }

        private readonly Dictionary<string, IUObject> _objecs = objecs;
        public void Execute()
        {
            IUObject obj = _objecs[(string)Order.GetValue("ObjectId")];
            moveObject = obj;
            ClearVelocity(obj);
            EndMove();
        }
        private void EndMove() => startMoveCommand.Inject(new NoCommand());

        private void ClearVelocity(IUObject obj)
        {
            var velocity = new Vector3(0, 0, 0);
            IVelocitySetter velocitySetter = new VelocitySetAdapter(obj);
            ICommand changeVelocityCommand = new VelocitySetCommand(velocitySetter, velocity);
            Commands.Enqueue(changeVelocityCommand);
        }
    }
}
