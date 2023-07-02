using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x1F3C8FCB)]
    class fearless_moment_difficulty_settings_obj : CatalogueObject
    {
        public fearless_moment_difficulty_settings_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<fearless_moment_difficulty_settings_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class fearless_moment_difficulty_settings_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x5A55B573)][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x05)] public uint field_5;
    }
}