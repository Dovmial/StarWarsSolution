using StarWarsConsoleApp.Adapters;
using StarWarsConsoleApp.Interfaces;
using System.Numerics;

namespace StarWarsConsoleApp.Commands
{
    public class StartMoveCommand(
        IUObject order,
        Queue<ICommand> commands,
        Dictionary<string, IUObject> objecs) : IMoveCommandStartable
    {
        public IInjectableCommand MoveCommand { get; private set; }
        public IUObject Order => order;
        public Queue<ICommand> Commands => commands;
        public Vector3 Velocity { get; } =
            (Vector3)order.GetValue(nameof(IMoveCommandStartable.Velocity));

        private readonly Dictionary<string, IUObject> _objecs = objecs;
        public void Execute()
        {
            IUObject obj = _objecs[(string)Order.GetValue("ObjectId")];
            SetVelocity(obj);
            StartMove(obj);
        }

        private void StartMove(IUObject obj)
        {
            IMovable movableObj = new MovableAdapter(obj);
            ICommand move = new MoveCommand(movableObj);
            IInjectableCommand moveBridge = new BridgeCommand();
            moveBridge.Inject(move);
            MoveCommand = moveBridge;
            Commands.Enqueue(moveBridge);
        }

        private void SetVelocity(IUObject obj)
        {
            IVelocitySetter velocitySetter = new VelocitySetAdapter(obj);
            ICommand changeVelocityCommand = new VelocitySetCommand(velocitySetter, Velocity);
            Commands.Enqueue(changeVelocityCommand);
        }
    }
}
