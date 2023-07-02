using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x595B71D8)]
    class u595b71d8_obj : CatalogueObject
    {
        public u595b71d8_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u595b71d8_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u595b71d8_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public int field_3;
    }
}