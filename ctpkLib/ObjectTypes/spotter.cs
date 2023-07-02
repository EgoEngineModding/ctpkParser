using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xA584E556)]
    class spotter_obj : CatalogueObject
    {
        public spotter_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<spotter_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class spotter_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x05)] public float field_5;
        [ProtoMember(0x06)] public float field_6;
    }
}