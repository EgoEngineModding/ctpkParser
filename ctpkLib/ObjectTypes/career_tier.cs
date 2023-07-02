using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x8B46BC8A)]
    class career_tier_obj : CatalogueObject
    {
        public career_tier_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<career_tier_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class career_tier_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0x8B46BC8A)][ProtoMember(0x04)] public uint field_4;
        [MappedObject(0x7D9D4F19)][ProtoMember(0x05)] public uint field_5;
        [MappedObject(0x7D9D4F19)][ProtoMember(0x06)] public uint field_6;
        [MappedObject(0x7D9D4F19)][ProtoMember(0x07)] public uint field_7;
        [MappedObject(0x7D9D4F19)][ProtoMember(0x08)] public uint field_8;
        [MappedObject(0x7D9D4F19)][ProtoMember(0x09)] public uint field_9;
        [MappedObject(0x7D9D4F19)][ProtoMember(0x0A)] public uint field_a;
        [MappedObject(0x7D9D4F19)][ProtoMember(0x0B)] public uint field_b;
        [MappedObject(0x7D9D4F19)][ProtoMember(0x0C)] public uint field_c;
        [ProtoMember(0x0D)] public int field_d;
        [MappedString][ProtoMember(0x0E)] public uint field_e;
        [ProtoMember(0x0F)] public uint field_f;
        [MappedString][ProtoMember(0x10)] public uint field_10;
    }
}