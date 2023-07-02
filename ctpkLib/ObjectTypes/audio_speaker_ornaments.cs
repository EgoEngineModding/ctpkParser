using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x27008937)]
    class audio_speaker_ornaments_obj : CatalogueObject
    {
        public audio_speaker_ornaments_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<audio_speaker_ornaments_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class audio_speaker_ornaments_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public float field_3;
    }
}