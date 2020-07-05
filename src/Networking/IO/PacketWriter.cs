using System.IO;

namespace Common.Networking.IO 
{
    public class PacketWriter : BinaryWriter 
    {
        private static MemoryStream stream;
        public PacketWriter() : base(stream = new MemoryStream()) { }
        public MemoryStream GetStream() => stream;
    }
}