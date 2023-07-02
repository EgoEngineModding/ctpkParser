using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x75B2CAD8)]
    class vehicle_part_category_obj : CatalogueObject
    {
        public vehicle_part_category_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<vehicle_part_category_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class vehicle_part_category_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
    }
}