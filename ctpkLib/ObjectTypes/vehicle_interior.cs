using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x7D9F2630)]
    class vehicle_interior_obj : CatalogueObject
    {
        public vehicle_interior_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<vehicle_interior_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class vehicle_interior_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x04)] public bool field_4;
        [MappedObject(0x60A97D64)][ProtoMember(0x05)] public uint field_5;
    }
}