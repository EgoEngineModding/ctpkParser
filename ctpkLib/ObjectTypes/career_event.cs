using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xF315FF18)]
    class career_event_obj : CatalogueObject
    {
        public career_event_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<career_event_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class career_event_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0xF4122B6A)][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0xF4122B6A)][ProtoMember(0x04)] public uint field_4;
        [MappedObject(0xF4122B6A)][ProtoMember(0x05)] public uint field_5;
        [MappedObject(0xF4122B6A)][ProtoMember(0x06)] public uint field_6;
        [MappedObject(0xF4122B6A)][ProtoMember(0x07)] public uint field_7;
        [MappedObject(0xF4122B6A)][ProtoMember(0x08)] public uint field_8;
        [MappedObject(0xF4122B6A)][ProtoMember(0x09)] public uint field_9;
        [MappedObject(0xF4122B6A)][ProtoMember(0x0A)] public uint field_a;
        [MappedObject(0xD1946D7C)][ProtoMember(0x10)] public uint field_10;
        [ProtoMember(0x11)] public float field_11;
        [ProtoMember(0x12)] public float field_12;
        [ProtoMember(0x13)] public float field_13;
    }
}