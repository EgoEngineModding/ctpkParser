using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x0B30DB19)]
    class lesson_obj : CatalogueObject
    {
        public lesson_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<lesson_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class lesson_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0xE8C824F6)][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0xA43B781A)][ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x05)] public uint field_5;
        [ProtoMember(0x06)] public uint field_6;
        [MappedObject(0xC16A87DF)][ProtoMember(0x07)] public uint field_7;
        [ProtoMember(0x08)] public float field_8;
        [ProtoMember(0x09)] public float field_9;
        [ProtoMember(0x0A)] public float field_a;
    }
}