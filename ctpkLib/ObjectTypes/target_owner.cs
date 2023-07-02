using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xB6E23496)]
    class target_owner_obj : CatalogueObject
    {
        public target_owner_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<target_owner_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class target_owner_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
    }
}