using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x302FDBCE)]
    class team_grade_obj : CatalogueObject
    {
        public team_grade_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<team_grade_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class team_grade_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x2E05BF50)][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0xD58E5B7B)][ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x06)] public uint field_6;
        [ProtoMember(0x07)] public uint field_7;
        [ProtoMember(0x08)] public float field_8;
        [ProtoMember(0x09)] public float field_9;
        [ProtoMember(0x0A)] public float field_a;
        [ProtoMember(0x0B)] public float field_b;
        [ProtoMember(0x0C)] public float field_c;
        [ProtoMember(0x0D)] public float field_d;
        [ProtoMember(0x0E)] public float field_e;
        [ProtoMember(0x0F)] public float field_f;
        [ProtoMember(0x10)] public uint field_10;
        [ProtoMember(0x11)] public float field_11;
        [ProtoMember(0x12)] public float field_12;
        [ProtoMember(0x13)] public int field_13;
        [ProtoMember(0x14)] public int field_14;
        [ProtoMember(0x15)] public int field_15;
        [ProtoMember(0x16)] public int field_16;
        [ProtoMember(0x17)] public int field_17;
        [ProtoMember(0x18)] public int field_18;
        [ProtoMember(0x19)] public int field_19;
        [ProtoMember(0x1A)] public uint field_1a;
        [ProtoMember(0x1B)] public bool field_1b;
    }
}