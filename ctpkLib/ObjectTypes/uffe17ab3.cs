using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xFFE17AB3)]
    class uffe17ab3_obj : CatalogueObject
    {
        public uffe17ab3_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<uffe17ab3_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class uffe17ab3_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
    }
}