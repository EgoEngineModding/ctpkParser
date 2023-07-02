using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x35EB3433)]
    class character_type_obj : CatalogueObject
    {
        public character_type_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<character_type_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class character_type_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
    }
}