using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x78446477)]
    class lesson_subtitles_obj : CatalogueObject
    {
        public lesson_subtitles_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<lesson_subtitles_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class lesson_subtitles_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
    }
}