
using StarWarsConsoleApp.Interfaces;

namespace StarWarsConsoleApp.Commands
{
    public class RotateCommand: ICommand
    {
        private IRotatable _rotatableObject;
        public int Angle { get; set; }
        public RotateCommand(IRotatable rotatableObject)
        {
            _rotatableObject = rotatableObject;
        }
        public void Execute()
        {
            _rotatableObject.RotationAngle = (_rotatableObject.RotationAngle + Angle) % 360; 
        }
    }
}
