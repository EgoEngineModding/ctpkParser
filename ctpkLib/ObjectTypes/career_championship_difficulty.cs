using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x25C2888B)]
    class career_championship_difficulty_obj : CatalogueObject
    {
        public career_championship_difficulty_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<career_championship_difficulty_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class career_championship_difficulty_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x7D9D4F19)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0xD1946D7C)][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public float field_4;
        [ProtoMember(0x05)] public float field_5;
        [ProtoMember(0x06)] public float field_6;
        [MappedObject(0xD1946D7C)][ProtoMember(0x07)] public uint field_7;
        [ProtoMember(0x08)] public float field_8;
        [ProtoMember(0x09)] public float field_9;
        [ProtoMember(0x0A)] public float field_a;
    }
}