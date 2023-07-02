using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x422D5A79)]
    class driver_punctures_obj : CatalogueObject
    {
        public driver_punctures_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<driver_punctures_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class driver_punctures_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public float field_3;
    }
}