using Common.Networking.Message;
using Common.Networking.IO;

namespace Common.Networking.Packet 
{
    public class ClientPacket : GamePacket
    {
        public ClientPacketType Opcode { get; set; }

        public ClientPacket(ClientPacketType opcode, IWritable writable = null)
        {
            using (var writer = new PacketWriter()) 
            {
                writer.Write((byte)opcode);
                if (writable != null) writable.Write(writer);

                var stream = writer.GetStream();
                Data = stream.ToArray();
                Size = stream.Length;
            }

            Opcode = opcode;
        }
    }
}