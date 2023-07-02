using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x06B2CDE3)]
    class track_lighting_types_obj : CatalogueObject
    {
        public track_lighting_types_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<track_lighting_types_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class track_lighting_types_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0x09CA07B5)][ProtoMember(0x04)] public uint field_4;
    }
}