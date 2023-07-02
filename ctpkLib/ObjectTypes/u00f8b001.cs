using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x00F8B001)]
    class u00f8b001_obj : CatalogueObject
    {
        public u00f8b001_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u00f8b001_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u00f8b001_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x8BB256AD)][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public float field_4;
        [ProtoMember(0x05)] public float field_5;
        [ProtoMember(0x06)] public float field_6;
        [ProtoMember(0x07)] public float field_7;
    }
}