using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xE0CA47B7)]
    class audio_name_obj : CatalogueObject
    {
        public audio_name_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<audio_name_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class audio_name_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public int field_4;
    }
}