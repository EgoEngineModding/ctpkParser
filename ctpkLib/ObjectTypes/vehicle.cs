using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x7245E185)]
    class vehicle_obj : CatalogueObject
    {
        public vehicle_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<vehicle_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class vehicle_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x0DCFD1E1)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x24F948D5)][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0xF68328FF)][ProtoMember(0x04)] public uint field_4;
        [MappedString][ProtoMember(0x05)] public uint field_5;
        [MappedObject(0x2442A3BA)][ProtoMember(0x0B)] public uint field_b;
        [MappedObject(0x7D9F2630)][ProtoMember(0x0C)] public uint field_c;
        [MappedString][ProtoMember(0x0D)] public uint field_d;
        [MappedString][ProtoMember(0x0E)] public uint field_e;
        [MappedString][ProtoMember(0x0F)] public uint field_f;
        [MappedString][ProtoMember(0x10)] public uint field_10;
        [ProtoMember(0x11)] public int field_11;
        [ProtoMember(0x12)] public int field_12;
        [ProtoMember(0x13)] public int field_13;
        [ProtoMember(0x14)] public int field_14;
        [ProtoMember(0x15)] public int field_15;
        [ProtoMember(0x18)] public float field_18;
        [ProtoMember(0x19)] public float field_19;
        [ProtoMember(0x1A)] public float field_1a;
        [ProtoMember(0x1D)] public bool field_1d;
        [ProtoMember(0x1E)] public bool field_1e;
        [ProtoMember(0x24)] public int field_24;
        [ProtoMember(0x25)] public int field_25;
        [ProtoMember(0x26)] public int field_26;
        [MappedString][ProtoMember(0x2C)] public uint field_2c;
        [ProtoMember(0x2D)] public bool field_2d;
        [ProtoMember(0x2E)] public bool field_2e;
        [ProtoMember(0x31)] public bool field_31;
        [ProtoMember(0x34)] public int field_34;
        [ProtoMember(0x35)] public int field_35;
        [ProtoMember(0x37)] public int field_37;
        [ProtoMember(0x39)] public int field_39;
        [MappedString][ProtoMember(0x3A)] public uint field_3a;
        [ProtoMember(0x43)] public int field_43;
        [ProtoMember(0x44)] public bool field_44;
        [ProtoMember(0x45)] public bool field_45;
        [MappedObject(0xF68328FF)][ProtoMember(0x4A)] public uint field_4a;
        [MappedObject(0xA52DC1AF)][ProtoMember(0x4B)] public uint field_4b;
        [MappedObject(0xFAE1141F)][ProtoMember(0x4C)] public uint field_4c;
        [MappedString][ProtoMember(0x4F)] public uint field_4f;
        [ProtoMember(0x50)] public bool field_50;
        [ProtoMember(0x51)] public bool field_51;
        [MappedObject(0x0084B2BF)][ProtoMember(0x52)] public uint field_52;
        [ProtoMember(0x53)] public bool field_53;
        [ProtoMember(0x54)] public bool field_54;
        [MappedString][ProtoMember(0x55)] public uint field_55;
        [ProtoMember(0x56)] public uint field_56;
        [ProtoMember(0x57)] public uint field_57;
        [ProtoMember(0x58)] public float field_58;
        [ProtoMember(0x59)] public uint field_59;
        [ProtoMember(0x5A)] public uint field_5a;
        [MappedObject(0x10B1563C)][ProtoMember(0x5B)] public uint field_5b;
        [ProtoMember(0x5D)] public uint field_5d;
        [ProtoMember(0x5E)] public int field_5e;
        [ProtoMember(0x5F)] public bool field_5f;
    }
}