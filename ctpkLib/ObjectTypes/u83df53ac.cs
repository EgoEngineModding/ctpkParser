using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x83DF53AC)]
    class u83df53ac_obj : CatalogueObject
    {
        public u83df53ac_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u83df53ac_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u83df53ac_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [MappedString][ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x05)] public float field_5;
        [ProtoMember(0x06)] public int field_6;
        [MappedObject(0x7695BA8B)][ProtoMember(0x07)] public uint field_7;
        [MappedObject(0x6FA5A0DE)][ProtoMember(0x08)] public uint field_8;
        [ProtoMember(0x09)] public uint field_9;
    }
}