using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x3AD63DB8)]
    class u3ad63db8_obj : CatalogueObject
    {
        public u3ad63db8_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u3ad63db8_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u3ad63db8_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public int field_4;
    }
}