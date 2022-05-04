using Hkmp.Networking.Packet;

namespace Test
{
    public class PacketData : IPacketData
    {
        public void WriteData(IPacket packet)
        {
            packet.Write(number);
        }

        public void ReadData(IPacket packet)
        {
            this.number = packet.ReadInt();
        }

        public bool IsReliable => true;
        public bool DropReliableDataIfNewerExists => false;

        public int number;
    }
}