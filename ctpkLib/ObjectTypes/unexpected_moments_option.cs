using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x01C8D874)]
    class unexpected_moments_option_obj : CatalogueObject
    {
        public unexpected_moments_option_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<unexpected_moments_option_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class unexpected_moments_option_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public bool field_4;
        [MappedString][ProtoMember(0x05)] public uint field_5;
    }
}