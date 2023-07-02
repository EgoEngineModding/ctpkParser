using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xA0CF0E20)]
    class career_stage_fearless_moments_obj : CatalogueObject
    {
        public career_stage_fearless_moments_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<career_stage_fearless_moments_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class career_stage_fearless_moments_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0xF4122B6A)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0xCF49F089)][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0xCF49F089)][ProtoMember(0x04)] public uint field_4;
        [MappedObject(0xCF49F089)][ProtoMember(0x05)] public uint field_5;
        [MappedObject(0xCF49F089)][ProtoMember(0x06)] public uint field_6;
        [MappedObject(0x2011D9BA)][ProtoMember(0x07)] public uint field_7;
    }
}