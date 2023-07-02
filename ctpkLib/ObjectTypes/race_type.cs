using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x0DCFD1E1)]
    class race_type_obj : CatalogueObject
    {
        public race_type_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<race_type_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class race_type_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x0E3953A3)][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0x3429DD3B)][ProtoMember(0x04)] public uint field_4;
        [MappedString][ProtoMember(0x05)] public uint field_5;
        [ProtoMember(0x06)] public bool field_6;
        [MappedObject(0xC2E3252C)][ProtoMember(0x07)] public uint field_7;
        [ProtoMember(0x08)] public bool field_8;
        [MappedObject(0x1153FD2A)][ProtoMember(0x09)] public uint field_9;
        [MappedObject(0x1153FD2A)][ProtoMember(0x0A)] public uint field_a;
        [MappedObject(0x1153FD2A)][ProtoMember(0x0B)] public uint field_b;
        [ProtoMember(0x0C)] public int field_c;
        [MappedString][ProtoMember(0x0D)] public uint field_d;
        [ProtoMember(0x0E)] public bool field_e;
        [ProtoMember(0x0F)] public bool field_f;
        [ProtoMember(0x10)] public bool field_10;
        [MappedObject(0x1153FD2A)][ProtoMember(0x11)] public uint field_11;
        [MappedObject(0xB0C02B14)][ProtoMember(0x12)] public uint field_12;
        [MappedObject(0xAFD2A37B)][ProtoMember(0x13)] public uint field_13;
        [ProtoMember(0x14)] public float field_14;
        [ProtoMember(0x15)] public bool field_15;
        [MappedString][ProtoMember(0x16)] public uint field_16;
        [ProtoMember(0x17)] public int field_17;
        [ProtoMember(0x18)] public bool field_18;
        [MappedString][ProtoMember(0x19)] public uint field_19;
        [ProtoMember(0x1A)] public bool field_1a;
        [MappedString][ProtoMember(0x1B)] public uint field_1b;
        [ProtoMember(0x1C)] public bool field_1c;
        [ProtoMember(0x1D)] public bool field_1d;
        [MappedObject(0x1153FD2A)][ProtoMember(0x1E)] public uint field_1e;
        [ProtoMember(0x1F)] public bool field_1f;
        [ProtoMember(0x20)] public int field_20;
        [ProtoMember(0x21)] public bool field_21;
        [ProtoMember(0x22)] public bool field_22;
        [MappedObject(0x1153FD2A)][ProtoMember(0x23)] public uint field_23;
    }
}