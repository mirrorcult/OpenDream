using Robust.Client;
using Robust.Client.ResourceManagement;
using Robust.Client.State;
using Robust.Client.UserInterface;
using Robust.Shared.Configuration;
using Robust.Shared.IoC;
using Robust.Shared.Network;

namespace OpenDreamClient.States.Connecting
{
    public class ConnectingState : State
    {
        [Dependency] private readonly IUserInterfaceManager _userInterfaceManager = default!;
        [Dependency] private readonly IResourceCache _resourceCache = default!;
        [Dependency] private readonly IConfigurationManager _configurationManager = default!;

        private ConnectingControl _connectingControl = default!;

        public override void Startup()
        {
            _connectingControl = new ConnectingControl(_resourceCache, _configurationManager);
            _userInterfaceManager.StateRoot.AddChild(_connectingControl);
        }

        public override void Shutdown()
        {
            _connectingControl.Dispose();
        }
    }
}
