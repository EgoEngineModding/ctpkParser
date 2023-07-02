using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xF96D6451)]
    class driver_obj : CatalogueObject
    {
        public driver_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<driver_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class driver_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x7EAE977A)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x7EAE977A)][ProtoMember(0x03)] public uint field_3;
        [MappedString][ProtoMember(0x05)] public uint field_5;
        [MappedString][ProtoMember(0x06)] public uint field_6;
        [MappedString][ProtoMember(0x07)] public uint field_7;
        [MappedObject(0xD8D448D1)][ProtoMember(0x0B)] public uint field_b;
        [ProtoMember(0x0F)] public int field_f;
        [MappedObject(0x7C9E660C)][ProtoMember(0x13)] public uint field_13;
        [ProtoMember(0x14)] public uint field_14;
        [MappedObject(0x3F5C5B41)][ProtoMember(0x16)] public uint field_16;
        [MappedObject(0xC16A87DF)][ProtoMember(0x18)] public uint field_18;
        [MappedObject(0xB97579C6)][ProtoMember(0x19)] public uint field_19;
        [MappedObject(0xC16A87DF)][ProtoMember(0x1A)] public uint field_1a;
        [MappedObject(0x41422076)][ProtoMember(0x1B)] public uint field_1b;
        [MappedObject(0xB2FC4B5C)][ProtoMember(0x1C)] public uint field_1c;
        [ProtoMember(0x1D)] public float field_1d;
        [MappedString][ProtoMember(0x1E)] public uint field_1e;
        [MappedString][ProtoMember(0x1F)] public uint field_1f;
        [MappedString][ProtoMember(0x20)] public uint field_20;
    }
}