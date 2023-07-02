using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xF4122B6A)]
    class career_stage_obj : CatalogueObject
    {
        public career_stage_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<career_stage_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class career_stage_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0xB8E12AAA)][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0x05A0FB7E)][ProtoMember(0x0B)] public uint field_b;
        [MappedObject(0xA170B822)][ProtoMember(0x0C)] public uint field_c;
        [MappedObject(0x4F12F227)][ProtoMember(0x0D)] public uint field_d;
        [ProtoMember(0x0F)] public int field_f;
        [ProtoMember(0x17)] public bool field_17;
        [ProtoMember(0x18)] public bool field_18;
        [ProtoMember(0x19)] public uint field_19;
        [ProtoMember(0x1A)] public int field_1a;
        [MappedObject(0x0B779432)][ProtoMember(0x1B)] public uint field_1b;
    }
}