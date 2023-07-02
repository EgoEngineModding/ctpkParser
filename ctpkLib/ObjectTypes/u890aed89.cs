using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x890AED89)]
    class u890aed89_obj : CatalogueObject
    {
        public u890aed89_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u890aed89_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u890aed89_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
    }
}