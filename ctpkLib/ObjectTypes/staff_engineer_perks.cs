using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xA1264B49)]
    class staff_engineer_perks_obj : CatalogueObject
    {
        public staff_engineer_perks_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<staff_engineer_perks_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class staff_engineer_perks_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [MappedString][ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x05)] public float field_5;
        [ProtoMember(0x06)] public uint field_6;
        [MappedObject(0xEE3BF852)][ProtoMember(0x08)] public uint field_8;
        [MappedObject(0xD8D448D1)][ProtoMember(0x09)] public uint field_9;
        [MappedObject(0xF68328FF)][ProtoMember(0x0A)] public uint field_a;
        [MappedObject(0xFAE1141F)][ProtoMember(0x0B)] public uint field_b;
        [ProtoMember(0x0C)] public uint field_c;
        [ProtoMember(0x0D)] public uint field_d;
        [MappedObject(0x7695BA8B)][ProtoMember(0x0F)] public uint field_f;
        [ProtoMember(0x10)] public uint field_10;
    }
}