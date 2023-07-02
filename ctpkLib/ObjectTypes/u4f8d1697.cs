using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x4F8D1697)]
    class u4f8d1697_obj : CatalogueObject
    {
        public u4f8d1697_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u4f8d1697_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u4f8d1697_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
    }
}