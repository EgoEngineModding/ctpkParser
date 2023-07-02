using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x08483FB7)]
    class u08483fb7_obj : CatalogueObject
    {
        public u08483fb7_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u08483fb7_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u08483fb7_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x03)] public float field_3;
        [MappedObject(0xFFE5A39B)][ProtoMember(0x04)] public uint field_4;
        [MappedObject(0xFFE5A39B)][ProtoMember(0x05)] public uint field_5;
    }
}