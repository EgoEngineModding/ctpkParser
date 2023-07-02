using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xF500D10A)]
    class ai_joker_lap_selection_obj : CatalogueObject
    {
        public ai_joker_lap_selection_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<ai_joker_lap_selection_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class ai_joker_lap_selection_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x1072479A)][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public float field_4;
        [ProtoMember(0x05)] public bool field_5;
        [ProtoMember(0x06)] public bool field_6;
        [ProtoMember(0x07)] public bool field_7;
        [ProtoMember(0x08)] public bool field_8;
        [ProtoMember(0x09)] public bool field_9;
        [ProtoMember(0x0A)] public bool field_a;
        [ProtoMember(0x0B)] public bool field_b;
        [ProtoMember(0x0C)] public bool field_c;
        [ProtoMember(0x0D)] public bool field_d;
        [ProtoMember(0x0E)] public bool field_e;
        [ProtoMember(0x0F)] public bool field_f;
        [ProtoMember(0x10)] public bool field_10;
        [ProtoMember(0x11)] public bool field_11;
    }
}