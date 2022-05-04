using Modding;
using Hkmp.Api.Client;
using Hkmp.Api.Server;

namespace Test
{
    public class Test : Mod
    {
        public override void Initialize()
        {
            ClientAddon.RegisterAddon(new TestClient());
            ServerAddon.RegisterAddon(new TestServer());
        }
    }
}
