using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x3FBB2D93)]
    class track_model_surface_degradation_obj : CatalogueObject
    {
        public track_model_surface_degradation_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<track_model_surface_degradation_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class track_model_surface_degradation_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0xB8E12AAA)][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public float field_3;
    }
}