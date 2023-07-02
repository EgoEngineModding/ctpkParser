using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xB8E12AAA)]
    class track_model_obj : CatalogueObject
    {
        public track_model_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<track_model_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class track_model_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public int field_3;
        [MappedObject(0xD3F53B19)][ProtoMember(0x04)] public uint field_4;
        [MappedObject(0x7604D91E)][ProtoMember(0x05)] public uint field_5;
        [MappedString][ProtoMember(0x06)] public uint field_6;
        [ProtoMember(0x07)] public bool field_7;
        [MappedString][ProtoMember(0x09)] public uint field_9;
        [MappedString][ProtoMember(0x0A)] public uint field_a;
        [MappedString][ProtoMember(0x0B)] public uint field_b;
        [MappedObject(0x1072479A)][ProtoMember(0x0C)] public uint field_c;
        [MappedString][ProtoMember(0x0D)] public uint field_d;
        [ProtoMember(0x0F)] public float field_f;
        [MappedString][ProtoMember(0x11)] public uint field_11;
        [MappedString][ProtoMember(0x12)] public uint field_12;
        [ProtoMember(0x13)] public float field_13;
        [ProtoMember(0x14)] public bool field_14;
        [MappedObject(0x3429DD3B)][ProtoMember(0x15)] public uint field_15;
        [ProtoMember(0x16)] public bool field_16;
        [ProtoMember(0x17)] public bool field_17;
        [ProtoMember(0x18)] public bool field_18;
        [ProtoMember(0x19)] public bool field_19;
        [ProtoMember(0x1A)] public bool field_1a;
        [ProtoMember(0x1B)] public bool field_1b;
        [ProtoMember(0x1D)] public float field_1d;
        [ProtoMember(0x1E)] public float field_1e;
        [ProtoMember(0x1F)] public float field_1f;
        [ProtoMember(0x20)] public float field_20;
        [ProtoMember(0x21)] public float field_21;
        [ProtoMember(0x22)] public float field_22;
        [ProtoMember(0x23)] public bool field_23;
        [ProtoMember(0x24)] public bool field_24;
        [ProtoMember(0x25)] public bool field_25;
        [MappedObject(0xA5819819)][ProtoMember(0x29)] public uint field_29;
        [MappedObject(0xA5819819)][ProtoMember(0x2A)] public uint field_2a;
        [MappedObject(0xA5819819)][ProtoMember(0x2B)] public uint field_2b;
        [MappedObject(0xA5819819)][ProtoMember(0x2C)] public uint field_2c;
        [MappedObject(0xA5819819)][ProtoMember(0x2D)] public uint field_2d;
        [MappedString][ProtoMember(0x2E)] public uint field_2e;
        [MappedObject(0x9F9E384A)][ProtoMember(0x2F)] public uint field_2f;
        [MappedString][ProtoMember(0x30)] public uint field_30;
        [ProtoMember(0x31)] public bool field_31;
        [ProtoMember(0x32)] public float field_32;
        [ProtoMember(0x33)] public bool field_33;
        [ProtoMember(0x34)] public int field_34;
        [MappedObject(0x0DCFD1E1)][ProtoMember(0x35)] public uint field_35;
        [ProtoMember(0x36)] public bool field_36;
        [MappedString][ProtoMember(0x38)] public uint field_38;
        [ProtoMember(0x39)] public bool field_39;
        [ProtoMember(0x3A)] public int field_3a;
        [ProtoMember(0x3B)] public int field_3b;
        [ProtoMember(0x3C)] public int field_3c;
        [ProtoMember(0x3D)] public int field_3d;
        [ProtoMember(0x3E)] public int field_3e;
        [ProtoMember(0x3F)] public bool field_3f;
        [ProtoMember(0x40)] public bool field_40;
        [ProtoMember(0x41)] public bool field_41;
        [MappedObject(0x62B8C779)][ProtoMember(0x42)] public uint field_42;
        [ProtoMember(0x43)] public float field_43;
        [ProtoMember(0x44)] public bool field_44;
        [ProtoMember(0x45)] public bool field_45;
        [ProtoMember(0x46)] public bool field_46;
        [MappedObject(0x1EC3046F)][ProtoMember(0x47)] public uint field_47;
        [ProtoMember(0x48)] public float field_48;
        [ProtoMember(0x49)] public uint field_49;
        [MappedString][ProtoMember(0x4A)] public uint field_4a;
        [MappedString][ProtoMember(0x4B)] public uint field_4b;
    }
}