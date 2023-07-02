using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x78690BEB)]
    class u78690beb_obj : CatalogueObject
    {
        public u78690beb_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u78690beb_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u78690beb_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public bool field_4;
    }
}