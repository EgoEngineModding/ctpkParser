using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xBF5C5813)]
    class stats_groups_obj : CatalogueObject
    {
        public stats_groups_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<stats_groups_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class stats_groups_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0x33513FF9)][ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x05)] public bool field_5;
    }
}