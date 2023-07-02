using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x9827A18B)]
    class components_obj : CatalogueObject
    {
        public components_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<components_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class components_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public bool field_3;
        [MappedString][ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x05)] public bool field_5;
    }
}