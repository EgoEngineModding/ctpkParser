using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xC16A87DF)]
    class vehicle_livery_obj : CatalogueObject
    {
        public vehicle_livery_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<vehicle_livery_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class vehicle_livery_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x93002513)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x7245E185)][ProtoMember(0x03)] public uint field_3;
        [MappedString][ProtoMember(0x04)] public uint field_4;
        [MappedString][ProtoMember(0x05)] public uint field_5;
        [ProtoMember(0x06)] public bool field_6;
        [ProtoMember(0x08)] public bool field_8;
        [ProtoMember(0x09)] public int field_9;
        [ProtoMember(0x0A)] public bool field_a;
        [MappedObject(0x92F6A4D1)][ProtoMember(0x0E)] public uint field_e;
        [MappedObject(0xE80962FC)][ProtoMember(0x10)] public uint field_10;
        [ProtoMember(0x17)] public bool field_17;
        [ProtoMember(0x18)] public bool field_18;
        [ProtoMember(0x19)] public bool field_19;
        [MappedObject(0x7C9E660C)][ProtoMember(0x1A)] public uint field_1a;
        [ProtoMember(0x1B)] public bool field_1b;
        [ProtoMember(0x1C)] public bool field_1c;
        [MappedObject(0x0084B2BF)][ProtoMember(0x1D)] public uint field_1d;
        [ProtoMember(0x1E)] public bool field_1e;
        [ProtoMember(0x1F)] public bool field_1f;
        [ProtoMember(0x20)] public bool field_20;
        [ProtoMember(0x21)] public bool field_21;
        [ProtoMember(0x23)] public uint field_23;
        [MappedString][ProtoMember(0x24)] public uint field_24;
        [MappedString][ProtoMember(0x25)] public uint field_25;
        [ProtoMember(0x26)] public bool field_26;
    }
}