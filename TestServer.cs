using Hkmp.Api.Server;

namespace Test
{
    public class TestServer : ServerAddon
    {
        public override void Initialize(IServerApi serverApi)
        {
            serverApi.ServerManager.PlayerConnectEvent += player => {
                serverApi.NetServer.GetNetworkSender<PacketId>(this).SendSingleData(PacketId.One, new PacketData() { number = 1 }, player.Id);
                serverApi.NetServer.GetNetworkSender<PacketId>(this).SendCollectionData(PacketId.Two, new PacketData() { number = 2 }, player.Id);
                serverApi.NetServer.GetNetworkSender<PacketId>(this).BroadcastSingleData(PacketId.Three, new PacketData() { number = 3 });
                serverApi.NetServer.GetNetworkSender<PacketId>(this).BroadcastCollectionData(PacketId.Four, new PacketData() { number = 4 });
            };
        }

        protected override string Name => "Test";
        protected override string Version => "0.0.0";
        public override bool NeedsNetwork => true;
    }
}