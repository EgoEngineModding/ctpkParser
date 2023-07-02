using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xD9AFF3CC)]
    class entity_mode_layer_bitset_obj : CatalogueObject
    {
        public entity_mode_layer_bitset_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<entity_mode_layer_bitset_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class entity_mode_layer_bitset_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public int field_3;
    }
}