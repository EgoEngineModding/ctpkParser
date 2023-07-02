using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xEE3FDE8A)]
    class rally_event_obj : CatalogueObject
    {
        public rally_event_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<rally_event_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class rally_event_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0xE35E8A7D)][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public int field_4;
        [ProtoMember(0x05)] public int field_5;
        [ProtoMember(0x06)] public int field_6;
        [ProtoMember(0x07)] public int field_7;
        [MappedObject(0xA5819819)][ProtoMember(0x08)] public uint field_8;
        [MappedObject(0xA5819819)][ProtoMember(0x09)] public uint field_9;
        [MappedObject(0xA5819819)][ProtoMember(0x0A)] public uint field_a;
        [MappedObject(0xA5819819)][ProtoMember(0x0B)] public uint field_b;
        [MappedObject(0xA5819819)][ProtoMember(0x0C)] public uint field_c;
    }
}