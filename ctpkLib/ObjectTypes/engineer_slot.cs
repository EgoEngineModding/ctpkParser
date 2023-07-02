using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xC9BE4513)]
    class engineer_slot_obj : CatalogueObject
    {
        public engineer_slot_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<engineer_slot_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class engineer_slot_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public int field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public int field_4;
        [ProtoMember(0x05)] public int field_5;
    }
}