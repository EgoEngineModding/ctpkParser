using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x9A4B0B66)]
    class u9a4b0b66_obj : CatalogueObject
    {
        public u9a4b0b66_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u9a4b0b66_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u9a4b0b66_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
    }
}