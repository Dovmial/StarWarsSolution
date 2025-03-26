
using StarWarsConsoleApp.Interfaces;

namespace StarWarsConsoleApp.Commands
{
    class BridgeCommand : IInjectableCommand
    {
        private ICommand _internalCommand;
        public void Execute()
        {
            if (_internalCommand is null)
                _internalCommand = new NoCommand();
            _internalCommand.Execute();
        }

        public void Inject(ICommand injectCommand) 
            => _internalCommand = injectCommand;
    }
}
