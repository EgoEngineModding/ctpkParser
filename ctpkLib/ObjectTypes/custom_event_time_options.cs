using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x0AB3309A)]
    class custom_event_time_options_obj : CatalogueObject
    {
        public custom_event_time_options_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<custom_event_time_options_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class custom_event_time_options_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public int field_2;
        [ProtoMember(0x03)] public int field_3;
        [MappedString][ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x05)] public int field_5;
        [MappedString][ProtoMember(0x06)] public uint field_6;
        [ProtoMember(0x07)] public int field_7;
        [MappedString][ProtoMember(0x08)] public uint field_8;
    }
}