using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xA6A68E21)]
    class component_audio_tannoy_obj : CatalogueObject
    {
        public component_audio_tannoy_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<component_audio_tannoy_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class component_audio_tannoy_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public int field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public bool field_4;
        [ProtoMember(0x05)] public bool field_5;
        [ProtoMember(0x06)] public int field_6;
    }
}