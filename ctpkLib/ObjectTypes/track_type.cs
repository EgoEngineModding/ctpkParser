using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x3429DD3B)]
    class track_type_obj : CatalogueObject
    {
        public track_type_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<track_type_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class track_type_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
    }
}