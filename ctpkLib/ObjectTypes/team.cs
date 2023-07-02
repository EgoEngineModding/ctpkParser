using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x7C9E660C)]
    class team_obj : CatalogueObject
    {
        public team_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<team_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class team_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [MappedString][ProtoMember(0x04)] public uint field_4;
        [MappedObject(0xFFA84151)][ProtoMember(0x05)] public uint field_5;
        [ProtoMember(0x06)] public float field_6;
        [ProtoMember(0x07)] public int field_7;
        [MappedString][ProtoMember(0x08)] public uint field_8;
        [MappedString][ProtoMember(0x09)] public uint field_9;
        [ProtoMember(0x0A)] public int field_a;
        [ProtoMember(0x0B)] public bool field_b;
        [ProtoMember(0x0C)] public bool field_c;
        [MappedString][ProtoMember(0x0D)] public uint field_d;
        [ProtoMember(0x0E)] public float field_e;
        [ProtoMember(0x10)] public bool field_10;
        [MappedObject(0xE770A54D)][ProtoMember(0x11)] public uint field_11;
        [ProtoMember(0x12)] public uint field_12;
        [ProtoMember(0x13)] public uint field_13;
        [ProtoMember(0x14)] public uint field_14;
        [MappedObject(0xD58E5B7B)][ProtoMember(0x15)] public uint field_15;
        [ProtoMember(0x16)] public uint field_16;
        [ProtoMember(0x17)] public uint field_17;
        [ProtoMember(0x18)] public uint field_18;
        [ProtoMember(0x19)] public int field_19;
        [ProtoMember(0x1A)] public bool field_1a;
        [MappedObject(0xA5819819)][ProtoMember(0x1C)] public uint field_1c;
        [ProtoMember(0x1D)] public bool field_1d;
        [ProtoMember(0x1E)] public bool field_1e;
        [MappedObject(0xA5819819)][ProtoMember(0x1F)] public uint field_1f;
        [ProtoMember(0x20)] public bool field_20;
        [ProtoMember(0x21)] public bool field_21;
        [MappedObject(0xA5819819)][ProtoMember(0x22)] public uint field_22;
        [ProtoMember(0x23)] public bool field_23;
        [ProtoMember(0x24)] public bool field_24;
        [MappedObject(0xA5819819)][ProtoMember(0x25)] public uint field_25;
        [ProtoMember(0x26)] public bool field_26;
        [ProtoMember(0x27)] public bool field_27;
        [MappedObject(0xA5819819)][ProtoMember(0x28)] public uint field_28;
        [ProtoMember(0x29)] public bool field_29;
        [ProtoMember(0x2A)] public bool field_2a;
        [MappedObject(0xA5819819)][ProtoMember(0x2B)] public uint field_2b;
        [ProtoMember(0x2C)] public bool field_2c;
        [ProtoMember(0x2D)] public bool field_2d;
        [ProtoMember(0x2E)] public int field_2e;
        [ProtoMember(0x2F)] public int field_2f;
        [MappedObject(0xEDB3E3D5)][ProtoMember(0x30)] public uint field_30;
        [MappedObject(0x9A4B0B66)][ProtoMember(0x31)] public uint field_31;
        [MappedObject(0xEDB3E3D5)][ProtoMember(0x32)] public uint field_32;
        [ProtoMember(0x33)] public bool field_33;
        [ProtoMember(0x34)] public uint field_34;
        [MappedObject(0x7D9D4F19)][ProtoMember(0x35)] public uint field_35;
        [ProtoMember(0x36)] public uint field_36;
    }
}