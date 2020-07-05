using System.IO;

namespace Common.Networking.IO 
{
    public class PacketReader : BinaryReader 
    {
        private static MemoryStream stream;
        
        public PacketReader(byte[] data) : base(stream = new MemoryStream(data)) { }

        public bool ReadBool() => base.ReadBoolean();
        public sbyte ReadInt8() => base.ReadSByte();
        public byte ReadUInt8() => base.ReadByte();
        public float ReadFloat() => base.ReadSingle();
    }
}