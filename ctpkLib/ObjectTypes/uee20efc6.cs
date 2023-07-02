using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xEE20EFC6)]
    class uee20efc6_obj : CatalogueObject
    {
        public uee20efc6_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<uee20efc6_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class uee20efc6_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
    }
}