using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x05FF4648)]
    class u05ff4648_obj : CatalogueObject
    {
        public u05ff4648_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u05ff4648_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u05ff4648_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0xF2075A24)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x3BE6AFF1)][ProtoMember(0x03)] public uint field_3;
        [MappedString][ProtoMember(0x04)] public uint field_4;
        [MappedString][ProtoMember(0x05)] public uint field_5;
        [MappedString][ProtoMember(0x06)] public uint field_6;
        [MappedString][ProtoMember(0x07)] public uint field_7;
        [MappedString][ProtoMember(0x08)] public uint field_8;
        [MappedString][ProtoMember(0x09)] public uint field_9;
        [MappedString][ProtoMember(0x0A)] public uint field_a;
        [MappedString][ProtoMember(0x0B)] public uint field_b;
        [MappedString][ProtoMember(0x0C)] public uint field_c;
        [MappedString][ProtoMember(0x0D)] public uint field_d;
        [MappedString][ProtoMember(0x0E)] public uint field_e;
        [MappedString][ProtoMember(0x0F)] public uint field_f;
        [MappedString][ProtoMember(0x10)] public uint field_10;
        [MappedString][ProtoMember(0x11)] public uint field_11;
        [MappedString][ProtoMember(0x12)] public uint field_12;
    }
}