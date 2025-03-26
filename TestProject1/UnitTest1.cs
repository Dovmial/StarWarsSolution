using StarWarsConsoleApp.Models;
using StarWarsConsoleApp.Commands;
using System.Numerics;
using StarWarsConsoleApp.Interfaces;
using StarWarsConsoleApp.Adapters;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(12, 5, 0, -7, 3, 0)]
        public void Test1(float x, float y, float z, float vx, float vy, float vz)
        {
            IUObject spaceship = new Spaceship(new(x, y, z), new(vx, vy, vz));
            IMovable spaceshipAdapter = new MovableAdapter(spaceship);
            ICommand move = new MoveCommand(spaceshipAdapter);
            move.Execute();
            Assert.Equal(
                new Vector3(5, 8, 0),
                spaceship.GetValue(nameof(Spaceship.Position)));
        }

        [Theory]
        [InlineData(5, 3, 0)]
        public void Test2(float vx, float vy, float vz)
        {
            Dictionary<string, IUObject> gameObjects = new();
            Queue<ICommand> commands = new();

            IUObject spaceship = new Spaceship(new(), new());
            gameObjects.Add(spaceship.Id, spaceship);

            IUObject order = new OrderMove(new(vx, vy, vz)) { ObjectId = spaceship.Id };
            IMoveCommandStartable startCommand = new StartMoveCommand(
                order,
                commands,
                gameObjects);

            startCommand.Execute();

            commands.Dequeue().Execute();
            Assert.Equal(new Vector3(0, 0, 0),
                spaceship.GetValue(nameof(Spaceship.Position)));
            Assert.Equal(new Vector3(5, 3, 0),
                spaceship.GetValue(nameof(Spaceship.Velocity)));

            commands.Dequeue().Execute();
            Assert.Equal(new Vector3(5, 3, 0),
                spaceship.GetValue(nameof(Spaceship.Position)));

        }

        [Theory]
        [InlineData(5, 3, 0)]
        public void Test3(float vx, float vy, float vz)
        {
            Dictionary<string, IUObject> gameObjects = new();
            Queue<ICommand> commands = new();

            IUObject spaceship = new Spaceship(new(), new());
            gameObjects.Add(spaceship.Id, spaceship);

            IUObject order = new OrderMove(new(vx, vy, vz)) { ObjectId = spaceship.Id };
            IMoveCommandStartable startCommand = new StartMoveCommand(
                order,
                commands,
                gameObjects);

            startCommand.Execute();
            IInjectableCommand injectableCommandMove = startCommand.MoveCommand;

            commands.Dequeue().Execute();
            Assert.Equal(new Vector3(vx,vy, vz),
               spaceship.GetValue(nameof(Spaceship.Velocity)));

            IUObject orderStop = new OrderMove(new(0,0,0)) { ObjectId = spaceship.Id };
            IMoveCommandEndable endMove = new EndMoveCommand(
                orderStop,
                injectableCommandMove,
                gameObjects,
                commands);
            endMove.Execute();

            commands.Dequeue().Execute();
            commands.Dequeue().Execute();

            //check clear velocity
            Assert.Equal(new Vector3(0, 0, 0),
               spaceship.GetValue(nameof(Spaceship.Velocity)));

            //check position (move canceled)
            Assert.Equal(new Vector3(0, 0, 0),
               spaceship.GetValue(nameof(Spaceship.Position)));
        }
    }
}
