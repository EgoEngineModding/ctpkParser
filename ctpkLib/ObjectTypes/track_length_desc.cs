using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x62B8C779)]
    class track_length_desc_obj : CatalogueObject
    {
        public track_length_desc_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<track_length_desc_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class track_length_desc_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
    }
}