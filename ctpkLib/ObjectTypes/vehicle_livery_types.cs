using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x93002513)]
    class vehicle_livery_types_obj : CatalogueObject
    {
        public vehicle_livery_types_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<vehicle_livery_types_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class vehicle_livery_types_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
    }
}