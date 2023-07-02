using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xBD1FD432)]
    class engineer_obj : CatalogueObject
    {
        public engineer_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<engineer_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class engineer_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public int field_3;
        [ProtoMember(0x04)] public int field_4;
        [ProtoMember(0x05)] public int field_5;
        [ProtoMember(0x06)] public int field_6;
        [ProtoMember(0x07)] public int field_7;
        [ProtoMember(0x08)] public int field_8;
        [ProtoMember(0x09)] public int field_9;
        [ProtoMember(0x0A)] public int field_a;
        [ProtoMember(0x0B)] public int field_b;
        [ProtoMember(0x0C)] public int field_c;
        [ProtoMember(0x0D)] public int field_d;
        [ProtoMember(0x0E)] public int field_e;
        [MappedString][ProtoMember(0x0F)] public uint field_f;
        [ProtoMember(0x10)] public bool field_10;
        [ProtoMember(0x11)] public bool field_11;
    }
}