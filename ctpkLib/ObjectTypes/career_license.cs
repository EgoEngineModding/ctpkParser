using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x0CED9379)]
    class career_license_obj : CatalogueObject
    {
        public career_license_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<career_license_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class career_license_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0xD0A4E79A)][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public int field_4;
        [MappedObject(0x7D9D4F19)][ProtoMember(0x05)] public uint field_5;
        [MappedObject(0x7D9D4F19)][ProtoMember(0x06)] public uint field_6;
        [MappedObject(0x7D9D4F19)][ProtoMember(0x07)] public uint field_7;
        [MappedObject(0x7D9D4F19)][ProtoMember(0x08)] public uint field_8;
        [MappedObject(0x7D9D4F19)][ProtoMember(0x09)] public uint field_9;
        [MappedObject(0x7D9D4F19)][ProtoMember(0x0A)] public uint field_a;
        [MappedObject(0x7D9D4F19)][ProtoMember(0x0B)] public uint field_b;
        [MappedObject(0x7D9D4F19)][ProtoMember(0x0C)] public uint field_c;
        [ProtoMember(0x0D)] public uint field_d;
        [MappedObject(0x0CED9379)][ProtoMember(0x0E)] public uint field_e;
        [ProtoMember(0x0F)] public bool field_f;
        [ProtoMember(0x10)] public bool field_10;
        [MappedString][ProtoMember(0x11)] public uint field_11;
        [ProtoMember(0x12)] public uint field_12;
        [ProtoMember(0x13)] public float field_13;
        [ProtoMember(0x14)] public int field_14;
        [ProtoMember(0x15)] public bool field_15;
        [ProtoMember(0x16)] public bool field_16;
    }
}