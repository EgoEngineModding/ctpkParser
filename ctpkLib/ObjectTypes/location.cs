using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x7604D91E)]
    class location_obj : CatalogueObject
    {
        public location_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<location_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class location_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0xD3F53B19)][ProtoMember(0x03)] public uint field_3;
        [MappedString][ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x05)] public int field_5;
        [MappedObject(0x744671E9)][ProtoMember(0x07)] public uint field_7;
        [MappedString][ProtoMember(0x0A)] public uint field_a;
        [MappedString][ProtoMember(0x0B)] public uint field_b;
        [MappedString][ProtoMember(0x0C)] public uint field_c;
        [MappedString][ProtoMember(0x0D)] public uint field_d;
        [ProtoMember(0x0E)] public uint field_e;
        [ProtoMember(0x0F)] public int field_f;
        [ProtoMember(0x10)] public int field_10;
        [ProtoMember(0x11)] public uint field_11;
        [ProtoMember(0x12)] public uint field_12;
        [MappedString][ProtoMember(0x13)] public uint field_13;
    }
}