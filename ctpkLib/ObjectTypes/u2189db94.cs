using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x2189DB94)]
    class u2189db94_obj : CatalogueObject
    {
        public u2189db94_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u2189db94_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u2189db94_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public float field_4;
        [ProtoMember(0x05)] public float field_5;
        [ProtoMember(0x06)] public float field_6;
        [ProtoMember(0x07)] public float field_7;
        [MappedObject(0xD1946D7C)][ProtoMember(0x08)] public uint field_8;
        [ProtoMember(0x09)] public float field_9;
    }
}