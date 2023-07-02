using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xC100FAB6)]
    class track_surface_types_obj : CatalogueObject
    {
        public track_surface_types_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<track_surface_types_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class track_surface_types_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public uint field_4;
    }
}