using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x41B53910)]
    class driver_damage_event_obj : CatalogueObject
    {
        public driver_damage_event_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<driver_damage_event_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class driver_damage_event_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [MappedString][ProtoMember(0x04)] public uint field_4;
        [MappedString][ProtoMember(0x05)] public uint field_5;
        [MappedString][ProtoMember(0x06)] public uint field_6;
        [MappedString][ProtoMember(0x07)] public uint field_7;
        [MappedString][ProtoMember(0x08)] public uint field_8;
    }
}