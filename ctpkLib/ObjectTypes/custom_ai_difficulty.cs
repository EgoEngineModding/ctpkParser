using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x823FCE3B)]
    class custom_ai_difficulty_obj : CatalogueObject
    {
        public custom_ai_difficulty_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<custom_ai_difficulty_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class custom_ai_difficulty_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public float field_3;
        [ProtoMember(0x04)] public float field_4;
    }
}