using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x4F12F227)]
    class u4f12f227_obj : CatalogueObject
    {
        public u4f12f227_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u4f12f227_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u4f12f227_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x03)] public float field_3;
        [ProtoMember(0x04)] public float field_4;
        [ProtoMember(0x05)] public float field_5;
        [ProtoMember(0x06)] public float field_6;
        [ProtoMember(0x07)] public float field_7;
        [ProtoMember(0x08)] public float field_8;
        [ProtoMember(0x09)] public float field_9;
        [ProtoMember(0x0A)] public float field_a;
        [ProtoMember(0x0B)] public float field_b;
        [ProtoMember(0x0C)] public float field_c;
        [ProtoMember(0x0D)] public float field_d;
        [ProtoMember(0x0E)] public float field_e;
        [ProtoMember(0x0F)] public float field_f;
        [ProtoMember(0x10)] public float field_10;
        [ProtoMember(0x11)] public float field_11;
        [ProtoMember(0x12)] public float field_12;
        [ProtoMember(0x13)] public float field_13;
        [ProtoMember(0x14)] public float field_14;
        [ProtoMember(0x15)] public float field_15;
        [ProtoMember(0x16)] public float field_16;
        [ProtoMember(0x17)] public float field_17;
        [ProtoMember(0x18)] public float field_18;
        [ProtoMember(0x19)] public float field_19;
        [ProtoMember(0x1A)] public float field_1a;
        [ProtoMember(0x1B)] public float field_1b;
        [ProtoMember(0x1C)] public float field_1c;
        [ProtoMember(0x1D)] public float field_1d;
        [ProtoMember(0x1E)] public float field_1e;
        [ProtoMember(0x1F)] public float field_1f;
        [ProtoMember(0x20)] public float field_20;
        [ProtoMember(0x21)] public float field_21;
        [ProtoMember(0x22)] public float field_22;
        [ProtoMember(0x23)] public float field_23;
        [ProtoMember(0x24)] public float field_24;
        [ProtoMember(0x25)] public float field_25;
        [ProtoMember(0x26)] public float field_26;
        [ProtoMember(0x27)] public float field_27;
        [ProtoMember(0x28)] public float field_28;
        [ProtoMember(0x29)] public float field_29;
        [ProtoMember(0x2A)] public float field_2a;
        [ProtoMember(0x2B)] public float field_2b;
        [ProtoMember(0x2C)] public float field_2c;
        [ProtoMember(0x2D)] public float field_2d;
        [ProtoMember(0x2E)] public float field_2e;
        [ProtoMember(0x2F)] public float field_2f;
        [ProtoMember(0x30)] public float field_30;
        [ProtoMember(0x31)] public float field_31;
        [ProtoMember(0x32)] public float field_32;
        [ProtoMember(0x33)] public float field_33;
        [ProtoMember(0x34)] public float field_34;
        [ProtoMember(0x35)] public float field_35;
        [ProtoMember(0x36)] public float field_36;
        [ProtoMember(0x37)] public float field_37;
        [ProtoMember(0x38)] public float field_38;
        [ProtoMember(0x39)] public float field_39;
        [ProtoMember(0x3A)] public float field_3a;
        [ProtoMember(0x3B)] public float field_3b;
        [ProtoMember(0x3C)] public float field_3c;
        [ProtoMember(0x3D)] public float field_3d;
        [ProtoMember(0x3E)] public float field_3e;
        [ProtoMember(0x3F)] public float field_3f;
        [ProtoMember(0x40)] public float field_40;
        [ProtoMember(0x41)] public float field_41;
        [ProtoMember(0x42)] public float field_42;
        [ProtoMember(0x43)] public float field_43;
        [ProtoMember(0x44)] public float field_44;
        [ProtoMember(0x45)] public float field_45;
        [ProtoMember(0x46)] public float field_46;
        [ProtoMember(0x47)] public float field_47;
        [ProtoMember(0x48)] public float field_48;
        [MappedObject(0xC09C7101)][ProtoMember(0x49)] public uint field_49;
        [MappedObject(0x01420DF3)][ProtoMember(0x4A)] public uint field_4a;
    }
}