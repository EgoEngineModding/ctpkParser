using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xD0F4C960)]
    class ud0f4c960_obj : CatalogueObject
    {
        public ud0f4c960_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<ud0f4c960_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class ud0f4c960_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public float field_2;
        [ProtoMember(0x03)] public float field_3;
        [ProtoMember(0x04)] public float field_4;
        [ProtoMember(0x05)] public float field_5;
        [ProtoMember(0x06)] public float field_6;
        [ProtoMember(0x07)] public float field_7;
        [ProtoMember(0x08)] public float field_8;
        [ProtoMember(0x09)] public int field_9;
        [ProtoMember(0x0A)] public int field_a;
        [ProtoMember(0x0B)] public float field_b;
        [ProtoMember(0x0C)] public float field_c;
        [ProtoMember(0x0D)] public float field_d;
        [ProtoMember(0x0E)] public float field_e;
        [ProtoMember(0x0F)] public int field_f;
        [ProtoMember(0x10)] public int field_10;
        [MappedString][ProtoMember(0x11)] public uint field_11;
        [MappedString][ProtoMember(0x12)] public uint field_12;
    }
}