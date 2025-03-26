using StarWarsConsoleApp.Interfaces;
using System.Numerics;

namespace StarWarsConsoleApp.Models
{
    public class Spaceship : UObject
    {
        public Vector3 Position { get; set; }
        public Vector3 Velocity { get; set; }
        public int RotationAngle { get; set; }

        public Spaceship(Vector3 pos, Vector3 velocity)
        {
            Position = pos;
            Velocity = velocity;
        }
    }

}
