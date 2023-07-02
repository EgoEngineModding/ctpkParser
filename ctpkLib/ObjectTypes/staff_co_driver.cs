using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x01416AD5)]
    class staff_co_driver_obj : CatalogueObject
    {
        public staff_co_driver_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<staff_co_driver_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class staff_co_driver_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0xD8D448D1)][ProtoMember(0x04)] public uint field_4;
        [MappedObject(0xD5C684E3)][ProtoMember(0x05)] public uint field_5;
        [ProtoMember(0x06)] public uint field_6;
        [ProtoMember(0x07)] public uint field_7;
        [MappedObject(0xD58E5B7B)][ProtoMember(0x08)] public uint field_8;
        [MappedObject(0xCE37D645)][ProtoMember(0x09)] public uint field_9;
        [MappedObject(0x1CCBED3B)][ProtoMember(0x0A)] public uint field_a;
        [MappedString][ProtoMember(0x0B)] public uint field_b;
        [ProtoMember(0x0C)] public uint field_c;
        [ProtoMember(0x0D)] public uint field_d;
        [ProtoMember(0x0E)] public uint field_e;
        [ProtoMember(0x0F)] public uint field_f;
        [ProtoMember(0x10)] public float field_10;
        [ProtoMember(0x11)] public bool field_11;
        [ProtoMember(0x12)] public uint field_12;
        [ProtoMember(0x13)] public int field_13;
        [ProtoMember(0x14)] public bool field_14;
        [MappedObject(0x7D9D4F19)][ProtoMember(0x15)] public uint field_15;
        [ProtoMember(0x16)] public uint field_16;
        [MappedObject(0x05927F7C)][ProtoMember(0x17)] public uint field_17;
    }
}