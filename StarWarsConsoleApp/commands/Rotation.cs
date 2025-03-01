
using StarWarsConsoleApp.Interfaces;

namespace StarWarsConsoleApp.Commands
{
    public class Rotation
    {
        private IRotatable _rotatableObject;
        public int Angle { get; set; }
        public Rotation(IRotatable rotatableObject)
        {
            _rotatableObject = rotatableObject;
        }
        public void Execute()
        {
            _rotatableObject.RotationAngle = (_rotatableObject.RotationAngle + Angle) % 360; 
        }
    }
}
