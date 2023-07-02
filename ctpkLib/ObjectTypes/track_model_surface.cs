using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x29199252)]
    class track_model_surface_obj : CatalogueObject
    {
        public track_model_surface_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<track_model_surface_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class track_model_surface_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0xB8E12AAA)][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0xC100FAB6)][ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x05)] public uint field_5;
        [MappedObject(0xF4122B6A)][ProtoMember(0x07)] public uint field_7;
    }
}