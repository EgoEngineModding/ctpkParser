using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xCEFF9E57)]
    class career_global_settings_obj : CatalogueObject
    {
        public career_global_settings_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<career_global_settings_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class career_global_settings_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public int field_2;
        [ProtoMember(0x03)] public int field_3;
        [ProtoMember(0x04)] public float field_4;
        [ProtoMember(0x05)] public float field_5;
        [ProtoMember(0x07)] public float field_7;
        [MappedObject(0xA5819819)][ProtoMember(0x08)] public uint field_8;
        [MappedObject(0x9F9E384A)][ProtoMember(0x09)] public uint field_9;
        [ProtoMember(0x0A)] public int field_a;
        [ProtoMember(0x0B)] public int field_b;
        [ProtoMember(0x0C)] public float field_c;
        [ProtoMember(0x0D)] public float field_d;
        [ProtoMember(0x0E)] public int field_e;
        [ProtoMember(0x0F)] public float field_f;
        [ProtoMember(0x10)] public uint field_10;
        [ProtoMember(0x11)] public int field_11;
        [ProtoMember(0x12)] public int field_12;
        [ProtoMember(0x13)] public int field_13;
        [ProtoMember(0x14)] public int field_14;
        [ProtoMember(0x15)] public uint field_15;
        [ProtoMember(0x16)] public uint field_16;
        [ProtoMember(0x17)] public uint field_17;
        [ProtoMember(0x18)] public int field_18;
        [ProtoMember(0x19)] public float field_19;
        [ProtoMember(0x1A)] public float field_1a;
    }
}