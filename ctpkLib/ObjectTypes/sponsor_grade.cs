using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xFFE5A39B)]
    class sponsor_grade_obj : CatalogueObject
    {
        public sponsor_grade_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<sponsor_grade_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class sponsor_grade_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x2E05BF50)][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x05)] public uint field_5;
        [ProtoMember(0x06)] public float field_6;
        [ProtoMember(0x07)] public float field_7;
        [ProtoMember(0x08)] public float field_8;
        [ProtoMember(0x09)] public float field_9;
        [ProtoMember(0x0A)] public float field_a;
        [ProtoMember(0x0B)] public float field_b;
        [ProtoMember(0x0C)] public float field_c;
        [ProtoMember(0x0D)] public float field_d;
        [ProtoMember(0x0E)] public float field_e;
        [ProtoMember(0x0F)] public float field_f;
        [ProtoMember(0x10)] public float field_10;
        [ProtoMember(0x11)] public float field_11;
        [ProtoMember(0x12)] public uint field_12;
        [ProtoMember(0x13)] public uint field_13;
    }
}