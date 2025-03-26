

using StarWarsConsoleApp.Interfaces;
using System.Numerics;

namespace StarWarsConsoleApp.Adapters
{
    public class VelocitySetAdapter(IUObject uObject) : IVelocitySetter
    {
        public Vector3 Velocity {
            set => uObject.SetValue(nameof(IVelocitySetter.Velocity), value);
        }
    }
}
