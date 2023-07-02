using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x4A51279B)]
    class u4a51279b_obj : CatalogueObject
    {
        public u4a51279b_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u4a51279b_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u4a51279b_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public float field_2;
        [ProtoMember(0x03)] public float field_3;
        [ProtoMember(0x04)] public float field_4;
        [ProtoMember(0x05)] public float field_5;
        [ProtoMember(0x06)] public float field_6;
        [ProtoMember(0x07)] public float field_7;
        [MappedString][ProtoMember(0x08)] public uint field_8;
        [ProtoMember(0x09)] public float field_9;
        [MappedString][ProtoMember(0x0A)] public uint field_a;
    }
}