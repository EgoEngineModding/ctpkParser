using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x8D18966E)]
    class u8d18966e_obj : CatalogueObject
    {
        public u8d18966e_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u8d18966e_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u8d18966e_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x7C9E660C)][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0xC16A87DF)][ProtoMember(0x04)] public uint field_4;
        [MappedString][ProtoMember(0x05)] public uint field_5;
        [MappedObject(0x4B2C34FE)][ProtoMember(0x06)] public uint field_6;
    }
}