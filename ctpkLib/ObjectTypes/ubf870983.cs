using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xBF870983)]
    class ubf870983_obj : CatalogueObject
    {
        public ubf870983_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<ubf870983_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class ubf870983_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x02849D72)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x1C311E01)][ProtoMember(0x03)] public uint field_3;
        [MappedString][ProtoMember(0x04)] public uint field_4;
        [MappedString][ProtoMember(0x05)] public uint field_5;
        [ProtoMember(0x06)] public uint field_6;
        [MappedString][ProtoMember(0x07)] public uint field_7;
        [MappedObject(0xF2AFA872)][ProtoMember(0x08)] public uint field_8;
        [MappedObject(0x4F7D6FD8)][ProtoMember(0x09)] public uint field_9;
        [MappedObject(0x4F7D6FD8)][ProtoMember(0x0A)] public uint field_a;
    }
}