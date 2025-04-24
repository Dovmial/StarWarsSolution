

using StarWarsConsoleApp.Interfaces;
using System.Numerics;

namespace StarWarsConsoleApp.Adapters
{
    public class MovableAdapter(IUObject uObject) : IMovable
    {
        public Vector3 Position {
            get => (Vector3)uObject.GetValue(nameof(IMovable.Position));
            set => uObject.SetValue(nameof(IMovable.Position), value);
        }
        public Vector3 Velocity
        {
            get
            {
                var velocity = (Vector3)uObject.GetValue(nameof(IMovable.Velocity));
                if (uObject is IRotatable)
                { 
                    //radians
                    var angle = (int)uObject.GetValue(nameof(IRotatable.RotationAngle));
                    return new Vector3(
                        (float)(velocity.X * Math.Cos(angle)),
                        (float)(velocity.Y * Math.Sin(angle)), 0.0f);
                }
                return velocity;
            }
        }
    }
}