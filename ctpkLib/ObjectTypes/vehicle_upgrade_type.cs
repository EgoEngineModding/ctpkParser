using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xAA64DA8D)]
    class vehicle_upgrade_type_obj : CatalogueObject
    {
        public vehicle_upgrade_type_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<vehicle_upgrade_type_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class vehicle_upgrade_type_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
    }
}