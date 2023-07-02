using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xE80962FC)]
    class vehicle_livery_pattern_obj : CatalogueObject
    {
        public vehicle_livery_pattern_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<vehicle_livery_pattern_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class vehicle_livery_pattern_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0x7245E185)][ProtoMember(0x04)] public uint field_4;
        [MappedObject(0x92F6A4D1)][ProtoMember(0x06)] public uint field_6;
        [MappedString][ProtoMember(0x07)] public uint field_7;
        [MappedString][ProtoMember(0x08)] public uint field_8;
        [MappedString][ProtoMember(0x09)] public uint field_9;
    }
}