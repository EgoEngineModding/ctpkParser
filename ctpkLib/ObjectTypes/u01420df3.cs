using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x01420DF3)]
    class u01420df3_obj : CatalogueObject
    {
        public u01420df3_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u01420df3_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u01420df3_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
    }
}