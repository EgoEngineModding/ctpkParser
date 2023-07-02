using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xC240D244)]
    class team_vehicle_data_obj : CatalogueObject
    {
        public team_vehicle_data_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<team_vehicle_data_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class team_vehicle_data_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x302FDBCE)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x744671E9)][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public float field_4;
        [ProtoMember(0x05)] public float field_5;
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
        [ProtoMember(0x12)] public float field_12;
        [ProtoMember(0x13)] public float field_13;
        [ProtoMember(0x14)] public float field_14;
        [ProtoMember(0x15)] public float field_15;
        [ProtoMember(0x16)] public float field_16;
        [ProtoMember(0x17)] public float field_17;
        [ProtoMember(0x18)] public float field_18;
        [ProtoMember(0x19)] public float field_19;
        [ProtoMember(0x1A)] public float field_1a;
        [ProtoMember(0x1B)] public float field_1b;
    }
}