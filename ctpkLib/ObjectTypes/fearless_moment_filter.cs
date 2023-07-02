using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x506AD8EE)]
    class fearless_moment_filter_obj : CatalogueObject
    {
        public fearless_moment_filter_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<fearless_moment_filter_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class fearless_moment_filter_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0xCF49F089)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x2F16630F)][ProtoMember(0x03)] public uint field_3;
    }
}