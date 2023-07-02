using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xAA699A71)]
    class rally_event_leaderboards_obj : CatalogueObject
    {
        public rally_event_leaderboards_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<rally_event_leaderboards_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class rally_event_leaderboards_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0xB8E12AAA)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x2442A3BA)][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0x24E2011C)][ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x05)] public int field_5;
    }
}