using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x1C311E01)]
    class u1c311e01_obj : CatalogueObject
    {
        public u1c311e01_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u1c311e01_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u1c311e01_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
    }
}