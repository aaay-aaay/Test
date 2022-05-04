using Hkmp.Api.Client;

namespace Test
{
    public class TestClient : ClientAddon
    {
        public override void Initialize(IClientApi clientApi)
        {
            var receiver = clientApi.NetClient.GetNetworkReceiver<PacketId>(this, id => {
                return new PacketData();
            });
            receiver.RegisterPacketHandler<PacketData>(PacketId.One, data => {
                Logger.Info(this, $"1 is {data.number}");
            });
            receiver.RegisterPacketHandler<PacketData>(PacketId.Two, data => {
                Logger.Info(this, $"2 is {data.number}");
            });
            receiver.RegisterPacketHandler<PacketData>(PacketId.Three, data => {
                Logger.Info(this, $"3 is {data.number}");
            });
            receiver.RegisterPacketHandler<PacketData>(PacketId.Four, data => {
                Logger.Info(this, $"4 is {data.number}");
            });
        }
        protected override string Name => "Test";
        protected override string Version => "0.0.0";
        public override bool NeedsNetwork => true;
    }
}