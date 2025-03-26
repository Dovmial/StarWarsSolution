

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
        public Vector3 Velocity => (Vector3)uObject.GetValue(nameof(IMovable.Velocity));
    }
}