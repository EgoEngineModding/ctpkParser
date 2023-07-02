using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x4F7D6FD8)]
    class u4f7d6fd8_obj : CatalogueObject
    {
        public u4f7d6fd8_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u4f7d6fd8_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u4f7d6fd8_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
    }
}