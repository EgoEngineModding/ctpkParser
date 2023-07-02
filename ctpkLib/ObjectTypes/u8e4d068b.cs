using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x8E4D068B)]
    class u8e4d068b_obj : CatalogueObject
    {
        public u8e4d068b_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u8e4d068b_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u8e4d068b_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x7604D91E)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x81163CCD)][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public bool field_4;
        [ProtoMember(0x05)] public bool field_5;
    }
}