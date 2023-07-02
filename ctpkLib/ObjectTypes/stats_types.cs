using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x544EFB08)]
    class stats_types_obj : CatalogueObject
    {
        public stats_types_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<stats_types_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class stats_types_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x0BAC4E93)][ProtoMember(0x03)] public uint field_3;
    }
}