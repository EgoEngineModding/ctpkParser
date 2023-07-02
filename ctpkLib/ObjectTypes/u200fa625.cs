using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x200FA625)]
    class u200fa625_obj : CatalogueObject
    {
        public u200fa625_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u200fa625_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u200fa625_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public int field_3;
        [ProtoMember(0x04)] public int field_4;
        [ProtoMember(0x07)] public int field_7;
        [ProtoMember(0x08)] public uint field_8;
    }
}