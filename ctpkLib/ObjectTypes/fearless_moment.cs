using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xCF49F089)]
    class fearless_moment_obj : CatalogueObject
    {
        public fearless_moment_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<fearless_moment_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class fearless_moment_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0xE18B738A)][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public uint field_4;
    }
}