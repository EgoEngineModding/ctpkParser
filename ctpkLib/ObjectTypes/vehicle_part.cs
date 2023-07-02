using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xBB4ECABB)]
    class vehicle_part_obj : CatalogueObject
    {
        public vehicle_part_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<vehicle_part_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class vehicle_part_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0xE94A7CFC)][ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x05)] public float field_5;
        [MappedString][ProtoMember(0x06)] public uint field_6;
        [ProtoMember(0x07)] public uint field_7;
        [MappedObject(0x7245E185)][ProtoMember(0x08)] public uint field_8;
        [ProtoMember(0x09)] public int field_9;
    }
}