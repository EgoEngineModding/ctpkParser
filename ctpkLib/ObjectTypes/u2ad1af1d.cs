using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x2AD1AF1D)]
    class u2ad1af1d_obj : CatalogueObject
    {
        public u2ad1af1d_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u2ad1af1d_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u2ad1af1d_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public bool field_2;
        [ProtoMember(0x03)] public bool field_3;
        [ProtoMember(0x04)] public bool field_4;
        [ProtoMember(0x05)] public bool field_5;
        [ProtoMember(0x06)] public bool field_6;
        [ProtoMember(0x07)] public bool field_7;
        [MappedString][ProtoMember(0x08)] public uint field_8;
        [MappedString][ProtoMember(0x09)] public uint field_9;
    }
}