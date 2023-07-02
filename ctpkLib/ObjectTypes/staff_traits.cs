using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x7F818AEF)]
    class staff_traits_obj : CatalogueObject
    {
        public staff_traits_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<staff_traits_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class staff_traits_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [MappedString][ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x05)] public bool field_5;
        [ProtoMember(0x06)] public bool field_6;
        [ProtoMember(0x07)] public bool field_7;
        [ProtoMember(0x08)] public bool field_8;
        [ProtoMember(0x09)] public int field_9;
        [ProtoMember(0x0A)] public float field_a;
        [ProtoMember(0x0B)] public bool field_b;
    }
}