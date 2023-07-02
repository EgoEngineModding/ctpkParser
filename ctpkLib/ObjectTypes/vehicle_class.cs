using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x2442A3BA)]
    class vehicle_class_obj : CatalogueObject
    {
        public vehicle_class_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<vehicle_class_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class vehicle_class_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x0B)] public int field_b;
        [ProtoMember(0x0D)] public bool field_d;
        [ProtoMember(0x0F)] public bool field_f;
        [ProtoMember(0x10)] public bool field_10;
        [ProtoMember(0x11)] public bool field_11;
        [MappedObject(0xBB511C98)][ProtoMember(0x12)] public uint field_12;
        [ProtoMember(0x13)] public bool field_13;
        [MappedString][ProtoMember(0x15)] public uint field_15;
        [MappedString][ProtoMember(0x16)] public uint field_16;
        [MappedString][ProtoMember(0x17)] public uint field_17;
        [ProtoMember(0x18)] public int field_18;
        [ProtoMember(0x19)] public float field_19;
        [ProtoMember(0x1A)] public float field_1a;
        [MappedObject(0xC16A87DF)][ProtoMember(0x1C)] public uint field_1c;
    }
}