using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xEE7DBB01)]
    class crowd_tint_groups_obj : CatalogueObject
    {
        public crowd_tint_groups_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<crowd_tint_groups_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class crowd_tint_groups_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
    }
}