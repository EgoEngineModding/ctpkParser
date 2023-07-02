using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xD1946D7C)]
    class distribution_curves_obj : CatalogueObject
    {
        public distribution_curves_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<distribution_curves_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class distribution_curves_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
    }
}