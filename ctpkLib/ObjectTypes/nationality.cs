using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xD8D448D1)]
    class nationality_obj : CatalogueObject
    {
        public nationality_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<nationality_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class nationality_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public bool field_3;
        [MappedString][ProtoMember(0x04)] public uint field_4;
        [MappedString][ProtoMember(0x05)] public uint field_5;
        [MappedObject(0x108252D8)][ProtoMember(0x06)] public uint field_6;
        [MappedObject(0x19BAA5D0)][ProtoMember(0x07)] public uint field_7;
        [ProtoMember(0x08)] public int field_8;
        [ProtoMember(0x09)] public bool field_9;
        [ProtoMember(0x0A)] public bool field_a;
        [ProtoMember(0x0C)] public int field_c;
    }
}