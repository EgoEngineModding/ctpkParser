using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x6FA5A0DE)]
    class sponsor_categories_obj : CatalogueObject
    {
        public sponsor_categories_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<sponsor_categories_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class sponsor_categories_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x04)] public uint field_4;
    }
}