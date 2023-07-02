using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xD58E5B7B)]
    class reputation_rank_obj : CatalogueObject
    {
        public reputation_rank_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<reputation_rank_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class reputation_rank_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x05)] public float field_5;
    }
}