using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x7AAAFBD7)]
    class staff_roster_obj : CatalogueObject
    {
        public staff_roster_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<staff_roster_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class staff_roster_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x05)] public bool field_5;
        [ProtoMember(0x06)] public float field_6;
        [MappedString][ProtoMember(0x07)] public uint field_7;
    }
}