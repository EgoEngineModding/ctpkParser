using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x59B7D589)]
    class difficulty_spreads_obj : CatalogueObject
    {
        public difficulty_spreads_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<difficulty_spreads_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class difficulty_spreads_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0xD1946D7C)][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public float field_4;
        [ProtoMember(0x05)] public float field_5;
        [ProtoMember(0x06)] public float field_6;
    }
}