using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xE6A5B53C)]
    class rallycross_event_format_obj : CatalogueObject
    {
        public rallycross_event_format_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<rallycross_event_format_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class rallycross_event_format_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
    }
}