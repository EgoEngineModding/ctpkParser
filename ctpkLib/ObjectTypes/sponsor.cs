using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xA5819819)]
    class sponsor_obj : CatalogueObject
    {
        public sponsor_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<sponsor_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class sponsor_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0x6FA5A0DE)][ProtoMember(0x1E)] public uint field_1e;
        [ProtoMember(0x1F)] public float field_1f;
        [MappedObject(0xD58E5B7B)][ProtoMember(0x21)] public uint field_21;
        [ProtoMember(0x24)] public uint field_24;
        [ProtoMember(0x25)] public uint field_25;
        [ProtoMember(0x26)] public uint field_26;
        [ProtoMember(0x27)] public uint field_27;
        [ProtoMember(0x2A)] public uint field_2a;
        [ProtoMember(0x2B)] public uint field_2b;
        [ProtoMember(0x2C)] public int field_2c;
        [ProtoMember(0x2D)] public bool field_2d;
        [ProtoMember(0x2E)] public bool field_2e;
        [ProtoMember(0x2F)] public uint field_2f;
        [ProtoMember(0x30)] public uint field_30;
        [MappedObject(0x7D9D4F19)][ProtoMember(0x31)] public uint field_31;
        [ProtoMember(0x32)] public uint field_32;
        [ProtoMember(0x33)] public int field_33;
    }
}