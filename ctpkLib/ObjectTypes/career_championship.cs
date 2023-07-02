using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x7D9D4F19)]
    class career_championship_obj : CatalogueObject
    {
        public career_championship_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<career_championship_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class career_championship_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0xF315FF18)][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0xF315FF18)][ProtoMember(0x04)] public uint field_4;
        [MappedObject(0xF315FF18)][ProtoMember(0x05)] public uint field_5;
        [MappedObject(0xF315FF18)][ProtoMember(0x06)] public uint field_6;
        [MappedObject(0xF315FF18)][ProtoMember(0x07)] public uint field_7;
        [MappedObject(0xF315FF18)][ProtoMember(0x08)] public uint field_8;
        [MappedObject(0xF315FF18)][ProtoMember(0x09)] public uint field_9;
        [MappedObject(0xF315FF18)][ProtoMember(0x0A)] public uint field_a;
        [MappedObject(0xF315FF18)][ProtoMember(0x0B)] public uint field_b;
        [MappedObject(0xF315FF18)][ProtoMember(0x0C)] public uint field_c;
        [MappedObject(0xF315FF18)][ProtoMember(0x0D)] public uint field_d;
        [MappedObject(0xF315FF18)][ProtoMember(0x0E)] public uint field_e;
        [MappedString][ProtoMember(0x30)] public uint field_30;
        [ProtoMember(0x31)] public int field_31;
        [ProtoMember(0x32)] public int field_32;
        [MappedObject(0x8D18966E)][ProtoMember(0x33)] public uint field_33;
        [MappedObject(0x8D18966E)][ProtoMember(0x34)] public uint field_34;
        [MappedObject(0x8D18966E)][ProtoMember(0x35)] public uint field_35;
        [MappedObject(0x8D18966E)][ProtoMember(0x36)] public uint field_36;
        [MappedObject(0x8D18966E)][ProtoMember(0x37)] public uint field_37;
        [MappedObject(0x8D18966E)][ProtoMember(0x38)] public uint field_38;
        [MappedObject(0x8D18966E)][ProtoMember(0x39)] public uint field_39;
        [MappedObject(0x8D18966E)][ProtoMember(0x3A)] public uint field_3a;
        [MappedObject(0x8D18966E)][ProtoMember(0x3B)] public uint field_3b;
        [MappedObject(0x8D18966E)][ProtoMember(0x3C)] public uint field_3c;
        [MappedObject(0x8D18966E)][ProtoMember(0x3D)] public uint field_3d;
        [MappedObject(0x8D18966E)][ProtoMember(0x3E)] public uint field_3e;
        [MappedObject(0x8D18966E)][ProtoMember(0x3F)] public uint field_3f;
        [MappedObject(0x8D18966E)][ProtoMember(0x40)] public uint field_40;
        [MappedObject(0x8D18966E)][ProtoMember(0x41)] public uint field_41;
        [MappedObject(0x8D18966E)][ProtoMember(0x42)] public uint field_42;
        [MappedObject(0x8D18966E)][ProtoMember(0x43)] public uint field_43;
        [MappedObject(0x8D18966E)][ProtoMember(0x44)] public uint field_44;
        [MappedObject(0x8D18966E)][ProtoMember(0x45)] public uint field_45;
        [MappedObject(0x8D18966E)][ProtoMember(0x46)] public uint field_46;
    }
}