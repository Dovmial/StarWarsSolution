using StarWarsConsoleApp;
using StarWarsConsoleApp.Adapters;
using StarWarsConsoleApp.Commands;
using StarWarsConsoleApp.Interfaces;
using StarWarsConsoleApp.Models;

Dictionary<string, IUObject> gameObjects = new();
Queue<ICommand> commands = new();

IUObject spaceship = new Spaceship(new(12, 5, 0), new(-7, 3, 0));

IMovable movableSpaceship = new MovableAdapter(spaceship);
ICommand move = new MoveCommand(movableSpaceship);

move.Execute();

Console.WriteLine(spaceship.GetValue(nameof(IMovable.Position)));
