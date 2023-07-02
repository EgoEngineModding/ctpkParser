using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xF5B43412)]
    class unlock_type_obj : CatalogueObject
    {
        public unlock_type_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<unlock_type_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class unlock_type_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
    }
}