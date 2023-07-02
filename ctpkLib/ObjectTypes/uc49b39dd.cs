using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xC49B39DD)]
    class uc49b39dd_obj : CatalogueObject
    {
        public uc49b39dd_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<uc49b39dd_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class uc49b39dd_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x7245E185)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x535271B1)][ProtoMember(0x03)] public uint field_3;
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
        [ProtoMember(0x16)] public float field_16;
        [ProtoMember(0x17)] public float field_17;
        [ProtoMember(0x18)] public float field_18;
        [ProtoMember(0x19)] public float field_19;
        [ProtoMember(0x1A)] public float field_1a;
        [ProtoMember(0x1B)] public float field_1b;
        [ProtoMember(0x1C)] public float field_1c;
        [ProtoMember(0x1D)] public float field_1d;
        [ProtoMember(0x1E)] public float field_1e;
        [ProtoMember(0x1F)] public float field_1f;
    }
}