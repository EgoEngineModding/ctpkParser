using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x291F85CC)]
    class u291f85cc_obj : CatalogueObject
    {
        public u291f85cc_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u291f85cc_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u291f85cc_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public float field_4;
        [ProtoMember(0x05)] public uint field_5;
        [ProtoMember(0x06)] public float field_6;
        [ProtoMember(0x07)] public uint field_7;
        [ProtoMember(0x08)] public uint field_8;
        [ProtoMember(0x09)] public uint field_9;
        [ProtoMember(0x0A)] public uint field_a;
        [ProtoMember(0x0B)] public uint field_b;
        [ProtoMember(0x0C)] public uint field_c;
        [ProtoMember(0x0D)] public uint field_d;
        [ProtoMember(0x0E)] public uint field_e;
        [ProtoMember(0x0F)] public uint field_f;
    }
}