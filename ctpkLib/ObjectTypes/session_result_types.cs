using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xAFD2A37B)]
    class session_result_types_obj : CatalogueObject
    {
        public session_result_types_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<session_result_types_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class session_result_types_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x436F7BF8)][ProtoMember(0x03)] public uint field_3;
    }
}