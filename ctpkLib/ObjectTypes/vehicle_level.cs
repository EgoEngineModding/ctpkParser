using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x24E2011C)]
    class vehicle_level_obj : CatalogueObject
    {
        public vehicle_level_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<vehicle_level_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class vehicle_level_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public int field_3;
        [MappedString][ProtoMember(0x04)] public uint field_4;
    }
}