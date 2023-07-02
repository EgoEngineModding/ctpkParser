using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xBDCE085A)]
    class audio_speaker_track_to_ornament_obj : CatalogueObject
    {
        public audio_speaker_track_to_ornament_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<audio_speaker_track_to_ornament_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class audio_speaker_track_to_ornament_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x1072479A)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x27008937)][ProtoMember(0x03)] public uint field_3;
    }
}