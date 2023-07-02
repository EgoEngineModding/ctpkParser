using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x0066330F)]
    class career_event_rewards_obj : CatalogueObject
    {
        public career_event_rewards_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<career_event_rewards_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class career_event_rewards_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public uint field_3;
        [MappedObject(0xF5B43412)][ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x05)] public uint field_5;
    }
}