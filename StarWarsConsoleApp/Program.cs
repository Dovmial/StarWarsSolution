using StarWarsConsoleApp;
using StarWarsConsoleApp.Commands;
using StarWarsConsoleApp.Models;

Spaceship spaceship = new Spaceship()
{
    Position = new(12,5,0),
    Velocity = new(-7,3,0)
};
Spaceship sp2 = new Spaceship();
Move moveSpaceship = new(spaceship);
Rotation rotationSpaceship = new(spaceship) { Angle = 10 };
moveSpaceship.Execute();
rotationSpaceship.Execute();

Move move2 = new(sp2);
move2.Execute();
Console.WriteLine(spaceship.Position.ToString());
Console.WriteLine(sp2.Position.ToString());
Console.WriteLine(spaceship.RotationAngle);