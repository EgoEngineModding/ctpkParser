using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x881C7D16)]
    class u881c7d16_obj : CatalogueObject
    {
        public u881c7d16_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u881c7d16_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u881c7d16_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x8BB256AD)][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public int field_4;
        [ProtoMember(0x05)] public int field_5;
        [ProtoMember(0x06)] public int field_6;
        [ProtoMember(0x07)] public int field_7;
    }
}