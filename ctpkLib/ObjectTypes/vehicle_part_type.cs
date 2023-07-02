using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xE94A7CFC)]
    class vehicle_part_type_obj : CatalogueObject
    {
        public vehicle_part_type_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<vehicle_part_type_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class vehicle_part_type_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x04)] public uint field_4;
        [MappedObject(0x75B2CAD8)][ProtoMember(0x05)] public uint field_5;
        [ProtoMember(0x07)] public bool field_7;
        [ProtoMember(0x08)] public bool field_8;
        [ProtoMember(0x09)] public bool field_9;
        [ProtoMember(0x0A)] public bool field_a;
        [ProtoMember(0x0B)] public bool field_b;
        [ProtoMember(0x0C)] public bool field_c;
        [ProtoMember(0x0D)] public bool field_d;
        [ProtoMember(0x0E)] public bool field_e;
        [ProtoMember(0x0F)] public bool field_f;
    }
}