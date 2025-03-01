using StarWarsConsoleApp.Interfaces;
using System.Numerics;

namespace StarWarsConsoleApp.Models
{
    public class Spaceship : IMovable, IRotatable
    {
        public Vector3 Position { get; set; }
        public Vector3 Velocity { get; set; }
        public int RotationAngle { get; set; }
    }

}
