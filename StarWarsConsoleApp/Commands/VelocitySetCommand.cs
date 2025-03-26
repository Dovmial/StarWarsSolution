
using StarWarsConsoleApp.Interfaces;
using System.Numerics;

namespace StarWarsConsoleApp.Commands
{
    public class VelocitySetCommand(
        IVelocitySetter velocitySetter,
        Vector3 newVelocity) : ICommand
    {
        public void Execute()
        {
            velocitySetter.Velocity = newVelocity;
        }
    }
}
