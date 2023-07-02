using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x4A705476)]
    class vehicle_part_template_obj : CatalogueObject
    {
        public vehicle_part_template_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<vehicle_part_template_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class vehicle_part_template_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [MappedString][ProtoMember(0x04)] public uint field_4;
        [MappedString][ProtoMember(0x05)] public uint field_5;
        [MappedString][ProtoMember(0x06)] public uint field_6;
        [MappedString][ProtoMember(0x07)] public uint field_7;
        [ProtoMember(0x08)] public int field_8;
        [ProtoMember(0x09)] public float field_9;
        [MappedString][ProtoMember(0x0A)] public uint field_a;
        [ProtoMember(0x0B)] public bool field_b;
        [ProtoMember(0x0C)] public bool field_c;
        [ProtoMember(0x0D)] public float field_d;
        [ProtoMember(0x0F)] public float field_f;
        [ProtoMember(0x10)] public float field_10;
        [MappedString][ProtoMember(0x11)] public uint field_11;
        [MappedString][ProtoMember(0x12)] public uint field_12;
        [MappedString][ProtoMember(0x13)] public uint field_13;
        [MappedString][ProtoMember(0x14)] public uint field_14;
        [MappedString][ProtoMember(0x15)] public uint field_15;
        [MappedObject(0x41B53910)][ProtoMember(0x16)] public uint field_16;
        [MappedString][ProtoMember(0x17)] public uint field_17;
        [MappedString][ProtoMember(0x18)] public uint field_18;
        [MappedString][ProtoMember(0x19)] public uint field_19;
        [ProtoMember(0x1A)] public bool field_1a;
        [ProtoMember(0x1B)] public float field_1b;
        [ProtoMember(0x1C)] public float field_1c;
        [ProtoMember(0x1D)] public float field_1d;
        [ProtoMember(0x1E)] public bool field_1e;
    }
}