using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x10614A14)]
    class stats_obj : CatalogueObject
    {
        public stats_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<stats_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class stats_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0xBF5C5813)][ProtoMember(0x04)] public uint field_4;
        [MappedString][ProtoMember(0x05)] public uint field_5;
        [MappedObject(0x544EFB08)][ProtoMember(0x06)] public uint field_6;
        [ProtoMember(0x07)] public bool field_7;
        [ProtoMember(0x08)] public bool field_8;
        [ProtoMember(0x09)] public bool field_9;
        [ProtoMember(0x0A)] public bool field_a;
        [MappedString][ProtoMember(0x0B)] public uint field_b;
        [ProtoMember(0x0C)] public bool field_c;
        [ProtoMember(0x0D)] public bool field_d;
        [ProtoMember(0x0E)] public bool field_e;
        [ProtoMember(0x0F)] public bool field_f;
        [MappedObject(0x0DCFD1E1)][ProtoMember(0x10)] public uint field_10;
        [MappedString][ProtoMember(0x11)] public uint field_11;
        [ProtoMember(0x12)] public bool field_12;
        [ProtoMember(0x13)] public int field_13;
    }
}