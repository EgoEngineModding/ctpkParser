using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x34AC2B67)]
    class staff_chief_engineer_perks_obj : CatalogueObject
    {
        public staff_chief_engineer_perks_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<staff_chief_engineer_perks_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class staff_chief_engineer_perks_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [MappedString][ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x08)] public float field_8;
        [ProtoMember(0x09)] public uint field_9;
        [MappedObject(0x7695BA8B)][ProtoMember(0x0A)] public uint field_a;
        [ProtoMember(0x0B)] public uint field_b;
    }
}