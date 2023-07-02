using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x7C9C36B7)]
    class perk_obj : CatalogueObject
    {
        public perk_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<perk_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class perk_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x668602B8)][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public float field_4;
        [MappedObject(0xF68328FF)][ProtoMember(0x05)] public uint field_5;
        [MappedObject(0xD8D448D1)][ProtoMember(0x06)] public uint field_6;
        [MappedObject(0x24E2011C)][ProtoMember(0x07)] public uint field_7;
        [ProtoMember(0x08)] public bool field_8;
        [ProtoMember(0x09)] public float field_9;
        [MappedObject(0x7245E185)][ProtoMember(0x0A)] public uint field_a;
        [MappedObject(0x2442A3BA)][ProtoMember(0x0B)] public uint field_b;
        [ProtoMember(0x0C)] public int field_c;
        [ProtoMember(0x0D)] public bool field_d;
        [MappedString][ProtoMember(0x0E)] public uint field_e;
    }
}