using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x33513FF9)]
    class stats_categories_obj : CatalogueObject
    {
        public stats_categories_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<stats_categories_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class stats_categories_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
    }
}