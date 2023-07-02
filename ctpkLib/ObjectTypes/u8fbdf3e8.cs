using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x8FBDF3E8)]
    class u8fbdf3e8_obj : CatalogueObject
    {
        public u8fbdf3e8_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u8fbdf3e8_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u8fbdf3e8_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public float field_2;
        [ProtoMember(0x03)] public float field_3;
        [ProtoMember(0x04)] public float field_4;
        [ProtoMember(0x05)] public float field_5;
        [ProtoMember(0x06)] public float field_6;
        [ProtoMember(0x07)] public float field_7;
    }
}