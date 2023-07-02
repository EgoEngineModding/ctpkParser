using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x0E3953A3)]
    class game_mode_obj : CatalogueObject
    {
        public game_mode_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<game_mode_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class game_mode_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0xD9AFF3CC)][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public bool field_4;
        [ProtoMember(0x05)] public bool field_5;
        [MappedString][ProtoMember(0x06)] public uint field_6;
        [ProtoMember(0x07)] public bool field_7;
        [ProtoMember(0x08)] public bool field_8;
        [ProtoMember(0x09)] public bool field_9;
        [ProtoMember(0x0A)] public bool field_a;
        [ProtoMember(0x0B)] public int field_b;
        [ProtoMember(0x0C)] public bool field_c;
        [ProtoMember(0x0D)] public bool field_d;
        [ProtoMember(0x0E)] public int field_e;
        [ProtoMember(0x0F)] public bool field_f;
        [ProtoMember(0x10)] public bool field_10;
        [ProtoMember(0x11)] public bool field_11;
        [ProtoMember(0x12)] public bool field_12;
        [ProtoMember(0x13)] public bool field_13;
        [ProtoMember(0x14)] public bool field_14;
        [ProtoMember(0x15)] public bool field_15;
        [ProtoMember(0x16)] public bool field_16;
        [ProtoMember(0x17)] public bool field_17;
        [ProtoMember(0x18)] public bool field_18;
        [ProtoMember(0x19)] public bool field_19;
        [ProtoMember(0x1A)] public bool field_1a;
        [ProtoMember(0x1C)] public bool field_1c;
        [ProtoMember(0x1D)] public bool field_1d;
        [ProtoMember(0x1E)] public bool field_1e;
        [ProtoMember(0x1F)] public bool field_1f;
        [ProtoMember(0x20)] public bool field_20;
    }
}