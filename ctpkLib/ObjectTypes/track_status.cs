using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xE35E8A7D)]
    class track_status_obj : CatalogueObject
    {
        public track_status_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<track_status_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class track_status_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
    }
}