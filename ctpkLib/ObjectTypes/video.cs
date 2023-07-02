using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x1091963C)]
    class video_obj : CatalogueObject
    {
        public video_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<video_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class video_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [MappedString][ProtoMember(0x04)] public uint field_4;
        [MappedString][ProtoMember(0x05)] public uint field_5;
        [ProtoMember(0x08)] public int field_8;
    }
}