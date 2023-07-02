using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x92F6A4D1)]
    class vehicle_livery_theme_obj : CatalogueObject
    {
        public vehicle_livery_theme_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<vehicle_livery_theme_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class vehicle_livery_theme_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x08)] public bool field_8;
        [MappedString][ProtoMember(0x09)] public uint field_9;
        [ProtoMember(0x0A)] public int field_a;
    }
}