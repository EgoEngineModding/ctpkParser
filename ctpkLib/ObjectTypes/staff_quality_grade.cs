using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xD5C684E3)]
    class staff_quality_grade_obj : CatalogueObject
    {
        public staff_quality_grade_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<staff_quality_grade_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class staff_quality_grade_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x2E05BF50)][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x05)] public int field_5;
        [ProtoMember(0x06)] public float field_6;
        [ProtoMember(0x07)] public float field_7;
        [ProtoMember(0x08)] public uint field_8;
    }
}